namespace UdpTestTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListenPort_t = new System.Windows.Forms.TextBox();
            this.DespIpAddr_t = new System.Windows.Forms.TextBox();
            this.SleepTimeMs_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendData_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SendOnceButton = new System.Windows.Forms.Button();
            this.SendManyButton = new System.Windows.Forms.Button();
            this.Recv_lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseButton = new System.Windows.Forms.Button();
            this.ListenButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.recvSpan_t = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recvCount_t = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.displayLiveData_cb = new System.Windows.Forms.CheckBox();
            this.BytesPerSec_t = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalBytes_t = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PktsPerSec_t = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveFile_t = new System.Windows.Forms.TextBox();
            this.WriteToOutFile_cb = new System.Windows.Forms.CheckBox();
            this.SendPort_t = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ConvertToAscii_cb = new System.Windows.Forms.CheckBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broadcast IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listen Port";
            // 
            // ListenPort_t
            // 
            this.ListenPort_t.Location = new System.Drawing.Point(284, 20);
            this.ListenPort_t.Margin = new System.Windows.Forms.Padding(2);
            this.ListenPort_t.Name = "ListenPort_t";
            this.ListenPort_t.Size = new System.Drawing.Size(43, 20);
            this.ListenPort_t.TabIndex = 2;
            this.ListenPort_t.Text = "45678";
            // 
            // DespIpAddr_t
            // 
            this.DespIpAddr_t.Location = new System.Drawing.Point(115, 20);
            this.DespIpAddr_t.Margin = new System.Windows.Forms.Padding(2);
            this.DespIpAddr_t.Name = "DespIpAddr_t";
            this.DespIpAddr_t.Size = new System.Drawing.Size(91, 20);
            this.DespIpAddr_t.TabIndex = 3;
            this.DespIpAddr_t.Text = "192.168.1.255";
            // 
            // SleepTimeMs_t
            // 
            this.SleepTimeMs_t.Location = new System.Drawing.Point(507, 18);
            this.SleepTimeMs_t.Margin = new System.Windows.Forms.Padding(2);
            this.SleepTimeMs_t.Name = "SleepTimeMs_t";
            this.SleepTimeMs_t.Size = new System.Drawing.Size(79, 20);
            this.SleepTimeMs_t.TabIndex = 5;
            this.SleepTimeMs_t.Text = "2000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate (ms)";
            // 
            // SendData_t
            // 
            this.SendData_t.Location = new System.Drawing.Point(115, 55);
            this.SendData_t.Margin = new System.Windows.Forms.Padding(2);
            this.SendData_t.Name = "SendData_t";
            this.SendData_t.Size = new System.Drawing.Size(470, 20);
            this.SendData_t.TabIndex = 7;
            this.SendData_t.Text = "Hello";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Content";
            // 
            // SendOnceButton
            // 
            this.SendOnceButton.Location = new System.Drawing.Point(597, 55);
            this.SendOnceButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendOnceButton.Name = "SendOnceButton";
            this.SendOnceButton.Size = new System.Drawing.Size(77, 18);
            this.SendOnceButton.TabIndex = 8;
            this.SendOnceButton.Text = "Send One";
            this.SendOnceButton.UseVisualStyleBackColor = true;
            this.SendOnceButton.Click += new System.EventHandler(this.SendOnceButton_Click);
            // 
            // SendManyButton
            // 
            this.SendManyButton.Location = new System.Drawing.Point(597, 19);
            this.SendManyButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendManyButton.Name = "SendManyButton";
            this.SendManyButton.Size = new System.Drawing.Size(77, 18);
            this.SendManyButton.TabIndex = 9;
            this.SendManyButton.Text = "Send Many";
            this.SendManyButton.UseVisualStyleBackColor = true;
            this.SendManyButton.Click += new System.EventHandler(this.SendManyButton_Click);
            // 
            // Recv_lv
            // 
            this.Recv_lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Recv_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.Recv_lv.Location = new System.Drawing.Point(22, 155);
            this.Recv_lv.Margin = new System.Windows.Forms.Padding(2);
            this.Recv_lv.Name = "Recv_lv";
            this.Recv_lv.Size = new System.Drawing.Size(653, 270);
            this.Recv_lv.TabIndex = 10;
            this.Recv_lv.UseCompatibleStateImageBehavior = false;
            this.Recv_lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Length";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 398;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "When";
            this.columnHeader3.Width = 218;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(617, 441);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(57, 29);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(597, 116);
            this.ListenButton.Margin = new System.Windows.Forms.Padding(2);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(77, 19);
            this.ListenButton.TabIndex = 12;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Lime;
            this.StatusLabel.Location = new System.Drawing.Point(18, 86);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 24);
            this.StatusLabel.TabIndex = 13;
            // 
            // recvSpan_t
            // 
            this.recvSpan_t.Location = new System.Drawing.Point(191, 93);
            this.recvSpan_t.Margin = new System.Windows.Forms.Padding(2);
            this.recvSpan_t.Name = "recvSpan_t";
            this.recvSpan_t.Size = new System.Drawing.Size(91, 20);
            this.recvSpan_t.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Recv Span:";
            // 
            // recvCount_t
            // 
            this.recvCount_t.Location = new System.Drawing.Point(352, 118);
            this.recvCount_t.Margin = new System.Windows.Forms.Padding(2);
            this.recvCount_t.Name = "recvCount_t";
            this.recvCount_t.Size = new System.Drawing.Size(71, 20);
            this.recvCount_t.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pkts Count:";
            // 
            // displayLiveData_cb
            // 
            this.displayLiveData_cb.AutoSize = true;
            this.displayLiveData_cb.Location = new System.Drawing.Point(22, 121);
            this.displayLiveData_cb.Margin = new System.Windows.Forms.Padding(2);
            this.displayLiveData_cb.Name = "displayLiveData_cb";
            this.displayLiveData_cb.Size = new System.Drawing.Size(109, 17);
            this.displayLiveData_cb.TabIndex = 18;
            this.displayLiveData_cb.Text = "Display Live Data";
            this.displayLiveData_cb.UseVisualStyleBackColor = true;
            // 
            // BytesPerSec_t
            // 
            this.BytesPerSec_t.Location = new System.Drawing.Point(507, 91);
            this.BytesPerSec_t.Margin = new System.Windows.Forms.Padding(2);
            this.BytesPerSec_t.Name = "BytesPerSec_t";
            this.BytesPerSec_t.Size = new System.Drawing.Size(65, 20);
            this.BytesPerSec_t.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bytes / sec:";
            // 
            // TotalBytes_t
            // 
            this.TotalBytes_t.Location = new System.Drawing.Point(352, 93);
            this.TotalBytes_t.Margin = new System.Windows.Forms.Padding(2);
            this.TotalBytes_t.Name = "TotalBytes_t";
            this.TotalBytes_t.Size = new System.Drawing.Size(71, 20);
            this.TotalBytes_t.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bytes Count:";
            // 
            // PktsPerSec_t
            // 
            this.PktsPerSec_t.Location = new System.Drawing.Point(507, 116);
            this.PktsPerSec_t.Margin = new System.Windows.Forms.Padding(2);
            this.PktsPerSec_t.Name = "PktsPerSec_t";
            this.PktsPerSec_t.Size = new System.Drawing.Size(65, 20);
            this.PktsPerSec_t.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Pkts / sec:";
            // 
            // SaveFile_t
            // 
            this.SaveFile_t.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveFile_t.Location = new System.Drawing.Point(91, 441);
            this.SaveFile_t.Margin = new System.Windows.Forms.Padding(2);
            this.SaveFile_t.Name = "SaveFile_t";
            this.SaveFile_t.Size = new System.Drawing.Size(167, 20);
            this.SaveFile_t.TabIndex = 26;
            this.SaveFile_t.Text = "c:\\data\\ttdata.txt";
            // 
            // WriteToOutFile_cb
            // 
            this.WriteToOutFile_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WriteToOutFile_cb.AutoSize = true;
            this.WriteToOutFile_cb.Checked = true;
            this.WriteToOutFile_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WriteToOutFile_cb.Location = new System.Drawing.Point(22, 441);
            this.WriteToOutFile_cb.Margin = new System.Windows.Forms.Padding(2);
            this.WriteToOutFile_cb.Name = "WriteToOutFile_cb";
            this.WriteToOutFile_cb.Size = new System.Drawing.Size(68, 17);
            this.WriteToOutFile_cb.TabIndex = 27;
            this.WriteToOutFile_cb.Text = "Out File :";
            this.WriteToOutFile_cb.UseVisualStyleBackColor = true;
            // 
            // SendPort_t
            // 
            this.SendPort_t.Location = new System.Drawing.Point(395, 20);
            this.SendPort_t.Margin = new System.Windows.Forms.Padding(2);
            this.SendPort_t.Name = "SendPort_t";
            this.SendPort_t.Size = new System.Drawing.Size(43, 20);
            this.SendPort_t.TabIndex = 29;
            this.SendPort_t.Text = "34567";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Send Port";
            // 
            // ConvertToAscii_cb
            // 
            this.ConvertToAscii_cb.AutoSize = true;
            this.ConvertToAscii_cb.Location = new System.Drawing.Point(135, 121);
            this.ConvertToAscii_cb.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertToAscii_cb.Name = "ConvertToAscii_cb";
            this.ConvertToAscii_cb.Size = new System.Drawing.Size(109, 17);
            this.ConvertToAscii_cb.TabIndex = 30;
            this.ConvertToAscii_cb.Text = "Convert To ASCII";
            this.ConvertToAscii_cb.UseVisualStyleBackColor = true;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 481);
            this.Controls.Add(this.ConvertToAscii_cb);
            this.Controls.Add(this.SendPort_t);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WriteToOutFile_cb);
            this.Controls.Add(this.SaveFile_t);
            this.Controls.Add(this.PktsPerSec_t);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BytesPerSec_t);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalBytes_t);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.displayLiveData_cb);
            this.Controls.Add(this.recvSpan_t);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recvCount_t);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ListenButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Recv_lv);
            this.Controls.Add(this.SendManyButton);
            this.Controls.Add(this.SendOnceButton);
            this.Controls.Add(this.SendData_t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SleepTimeMs_t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DespIpAddr_t);
            this.Controls.Add(this.ListenPort_t);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UDP Test Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ListenPort_t;
        private System.Windows.Forms.TextBox DespIpAddr_t;
        private System.Windows.Forms.TextBox SleepTimeMs_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SendData_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendOnceButton;
        private System.Windows.Forms.Button SendManyButton;
        private System.Windows.Forms.ListView Recv_lv;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox recvSpan_t;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recvCount_t;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox displayLiveData_cb;
        private System.Windows.Forms.TextBox BytesPerSec_t;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalBytes_t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PktsPerSec_t;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SaveFile_t;
        private System.Windows.Forms.CheckBox WriteToOutFile_cb;
        private System.Windows.Forms.TextBox SendPort_t;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ConvertToAscii_cb;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

