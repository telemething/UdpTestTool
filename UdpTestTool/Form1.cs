using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UdpTestTool
{
    public partial class Form1 : Form
    {
        private Thread _ListenerThread;
        private Thread _SendThread;
        private bool _Close = false;
        private int _RecvCount = 0;
        private ulong _RecvBytesTotal;
        System.Diagnostics.Stopwatch _Timer = null;
        private System.IO.StreamWriter _outFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void SendOnceButton_Click(object sender, EventArgs e)
        {
            SendOne(DespIpAddr_t.Text, Convert.ToInt32(SendPort_t.Text), SendData_t.Text);
            StatusLabel.Text = "Data Sent";
        }

        private void SendManyButton_Click(object sender, EventArgs e)
        {
            _SendThread = new Thread(new ThreadStart(SendMany));
            _SendThread.Start();
            StatusLabel.Text = "Sending";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _Close = true;
            this.Close();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            _ListenerThread = new Thread(new ThreadStart(UdpListener));
            _ListenerThread.Start();
            StatusLabel.Text = "Listening";
        }

        void SendMany()
        {
            SendMany(DespIpAddr_t.Text, Convert.ToInt32(ListenPort_t.Text), SendData_t.Text);
        }

        void SendMany(string destIP, int destPort, string data)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
                ProtocolType.Udp);

            s.ExclusiveAddressUse = false;
            s.EnableBroadcast = true;

            IPAddress broadcast = IPAddress.Parse(destIP);
            IPEndPoint ep = new IPEndPoint(broadcast, destPort);
            byte[] sendbuf;

            while (!_Close)
            {
                sendbuf = Encoding.ASCII.GetBytes(data + DateTime.UtcNow.ToLongTimeString());
                s.SendTo(sendbuf, ep);
                Console.WriteLine("Message sent to the broadcast address");
                Thread.Sleep(Convert.ToInt32(SleepTimeMs_t.Text));
            }

        }

        void SendOne(string destIP, int destPort, string data)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
                ProtocolType.Udp);

            s.ExclusiveAddressUse = false;
            s.EnableBroadcast = true;

            IPAddress broadcast = IPAddress.Parse(destIP);

            byte[] sendbuf = Encoding.ASCII.GetBytes(data);
            IPEndPoint ep = new IPEndPoint(broadcast, destPort);

            s.SendTo(sendbuf, ep);

            Console.WriteLine("Message sent to the broadcast address");
        }

        private void UdpListener()
        {
            UdpListener(Convert.ToInt32(ListenPort_t.Text));
        }

        const string RECORDSTORE_FORMAT = @"{{T:""{0}"",D:""{1}""}},";

        private async void UdpListener( int listenPort)
        {
            UdpClient listener;
            IPEndPoint groupEP;

            try
            {
                //listener = new UdpClient(listenPort);
                groupEP = new IPEndPoint(IPAddress.Any, listenPort);
                listener = new UdpClient
                {
                    ExclusiveAddressUse = false,
                    EnableBroadcast = true
                };

                listener.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                listener.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, false);

                listener.Client.Bind(groupEP);
                OpenOutFile(SaveFile_t.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                while (!_Close)
                {
                    //Console.WriteLine("Waiting for broadcast");
                    byte[] bytes;

                    //byte[] bytes = listener.Receive(ref groupEP);

                    var thing = await listener.ReceiveAsync();
                    bytes = thing.Buffer;

                    var sender = thing.RemoteEndPoint.Address.ToString() + ":" + thing.RemoteEndPoint.Port.ToString();

                    if (null == _Timer)
                        _Timer = System.Diagnostics.Stopwatch.StartNew();

                    /*Console.WriteLine("Received broadcast from {0} :\n {1}\n",
                        groupEP.ToString(),
                        Encoding.ASCII.GetString(bytes, 0, bytes.Length));*/

                    var elapsedTime = _Timer.Elapsed;
                    var recvCount = (_RecvCount++).ToString();
                    var elapsedTime_s = elapsedTime.ToString("mm':'ss':'fff");
                    _RecvBytesTotal += (ulong)bytes.Length;

                    string data;

                    if (ConvertToAscii_cb.Checked)
                    {
                        data = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

                        //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(data);

                        //var jsonObj = Newtonsoft.Json.Linq.JObject.Parse(data);

                        //var tipe= jsonObj["type"];

                        /*dynamic jsonObj = Newtonsoft.Json.Linq.JObject.Parse(data);

                        string type = jsonObj.type;
                        string id = jsonObj.id;
                        long tow = jsonObj.tow;
                        long lat = jsonObj.coord.lat;
                        long lon = jsonObj.coord.lon;
                        long alt = jsonObj.coord.alt;*/
                    }
                    else
                        data = ByteArrayToString(bytes, 0, bytes.Length);

                    //int fff = data.Length;


                    WriteToOutFile(string.Format(RECORDSTORE_FORMAT, elapsedTime.TotalMilliseconds.ToString(), data));

                    PktsPerSec_t.Invoke(
                        new ThreadStart(delegate
                        {
                            PktsPerSec_t.Text = Math.Round(_RecvCount / elapsedTime.TotalSeconds, 1).ToString();
                        }));

                    TotalBytes_t.Invoke(
                        new ThreadStart(delegate
                        {
                            TotalBytes_t.Text = _RecvBytesTotal.ToString();
                        }));

                    BytesPerSec_t.Invoke(
                        new ThreadStart(delegate
                        {
                            BytesPerSec_t.Text = Math.Round(_RecvBytesTotal / elapsedTime.TotalSeconds).ToString();
                        }));

                    recvCount_t.Invoke(
                        new ThreadStart(delegate
                        {
                            recvCount_t.Text = recvCount;
                        }));

                    recvSpan_t.Invoke(
                        new ThreadStart(delegate
                        {
                            recvSpan_t.Text = elapsedTime_s;
                        }));

                    if (displayLiveData_cb.Checked)
                    {
                        var lvi = new ListViewItem(recvCount);
                        lvi.SubItems.Add(sender);
                        lvi.SubItems.Add(bytes.Length.ToString());
                        lvi.SubItems.Add(data);
                        lvi.SubItems.Add(elapsedTime_s);
            
                        if (Recv_lv.InvokeRequired)
                        {
                            Recv_lv.Invoke(
                                new ThreadStart(delegate
                                {
                                    Recv_lv.Items.Add(lvi);
                                    //Recv_lv.FocusedItem = lvi;
                                }));
                        }
                        else
                        {
                            Recv_lv.Items.Add(lvi);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }

        private void WriteToOutFile(string data)
        {
            if (null != _outFile)
                _outFile.WriteLineAsync(data);
        }

        const string HEADER_FORMAT = @"{{DateTime:""{0}"",Source:""{1}"",RecordList:{{";
        const string FOOTER_FORMAT = @"{{T:""{0}"",D:""{1}""}}}}";

        private void OpenOutFile(string filePath)
        {
            if(WriteToOutFile_cb.Checked)
                if (0 < filePath.Length)
                    _outFile = new System.IO.StreamWriter(filePath, false);

            WriteToOutFile(string.Format(HEADER_FORMAT, DateTime.Now.ToLongTimeString(), "xxx"));
        }

        private void CloseOutFile()
        {
            if (null == _outFile)
                return;

            WriteToOutFile(string.Format(FOOTER_FORMAT, _Timer.Elapsed.TotalMilliseconds.ToString(), ""));
            _outFile.Flush();
            _outFile.Close();
            _outFile.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Close = true;

            if (null != _ListenerThread)
                _ListenerThread.Abort();

            if (null != _SendThread)
                _SendThread.Abort();

            CloseOutFile();
        }

        string ByteArrayToString(Byte[] ba, int start, int length)
        {
            var hex = BitConverter.ToString(ba, start, length);
            return hex.Replace("-", "");
        }

    }
}
