namespace SToolkit.SocketNetwork.WinFormsDemo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TcpServerIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TcpServerLog = new System.Windows.Forms.RichTextBox();
            this.TcpStop = new System.Windows.Forms.Button();
            this.TcpStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TcpServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TcpSend = new System.Windows.Forms.Button();
            this.TcpData = new System.Windows.Forms.TextBox();
            this.TcpClientLog = new System.Windows.Forms.RichTextBox();
            this.TcpDisconnect = new System.Windows.Forms.Button();
            this.TcpConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TcpClientPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TcpClientIP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UdpSend = new System.Windows.Forms.Button();
            this.UdpData = new System.Windows.Forms.TextBox();
            this.UdpClientLog = new System.Windows.Forms.RichTextBox();
            this.UdpDisconnect = new System.Windows.Forms.Button();
            this.UdpConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UdpClientPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UdpClientIP = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UdpServerLog = new System.Windows.Forms.RichTextBox();
            this.UdpStop = new System.Windows.Forms.Button();
            this.UdpStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UdpServerPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UdpServerIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcpServerIP
            // 
            this.TcpServerIP.Location = new System.Drawing.Point(45, 19);
            this.TcpServerIP.Name = "TcpServerIP";
            this.TcpServerIP.Size = new System.Drawing.Size(100, 20);
            this.TcpServerIP.TabIndex = 0;
            this.TcpServerIP.Text = "127.0.0.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TcpServerLog);
            this.groupBox1.Controls.Add(this.TcpStop);
            this.groupBox1.Controls.Add(this.TcpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TcpServerPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TcpServerIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TcpServer";
            // 
            // TcpServerLog
            // 
            this.TcpServerLog.Location = new System.Drawing.Point(151, 19);
            this.TcpServerLog.Name = "TcpServerLog";
            this.TcpServerLog.Size = new System.Drawing.Size(189, 171);
            this.TcpServerLog.TabIndex = 6;
            this.TcpServerLog.Text = "";
            // 
            // TcpStop
            // 
            this.TcpStop.Location = new System.Drawing.Point(9, 100);
            this.TcpStop.Name = "TcpStop";
            this.TcpStop.Size = new System.Drawing.Size(136, 23);
            this.TcpStop.TabIndex = 5;
            this.TcpStop.Text = "Stop";
            this.TcpStop.UseVisualStyleBackColor = true;
            this.TcpStop.Click += new System.EventHandler(this.TcpStop_Click);
            // 
            // TcpStart
            // 
            this.TcpStart.Location = new System.Drawing.Point(9, 71);
            this.TcpStart.Name = "TcpStart";
            this.TcpStart.Size = new System.Drawing.Size(136, 23);
            this.TcpStart.TabIndex = 4;
            this.TcpStart.Text = "Start";
            this.TcpStart.UseVisualStyleBackColor = true;
            this.TcpStart.Click += new System.EventHandler(this.TcpStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // TcpServerPort
            // 
            this.TcpServerPort.Location = new System.Drawing.Point(45, 45);
            this.TcpServerPort.Name = "TcpServerPort";
            this.TcpServerPort.Size = new System.Drawing.Size(100, 20);
            this.TcpServerPort.TabIndex = 2;
            this.TcpServerPort.Text = "5400";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TcpSend);
            this.groupBox2.Controls.Add(this.TcpData);
            this.groupBox2.Controls.Add(this.TcpClientLog);
            this.groupBox2.Controls.Add(this.TcpDisconnect);
            this.groupBox2.Controls.Add(this.TcpConnect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TcpClientPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TcpClientIP);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TcpClient";
            // 
            // TcpSend
            // 
            this.TcpSend.Location = new System.Drawing.Point(9, 149);
            this.TcpSend.Name = "TcpSend";
            this.TcpSend.Size = new System.Drawing.Size(136, 23);
            this.TcpSend.TabIndex = 15;
            this.TcpSend.Text = "Send";
            this.TcpSend.UseVisualStyleBackColor = true;
            this.TcpSend.Click += new System.EventHandler(this.TcpSend_Click);
            // 
            // TcpData
            // 
            this.TcpData.Location = new System.Drawing.Point(9, 123);
            this.TcpData.Name = "TcpData";
            this.TcpData.Size = new System.Drawing.Size(136, 20);
            this.TcpData.TabIndex = 14;
            // 
            // TcpClientLog
            // 
            this.TcpClientLog.Location = new System.Drawing.Point(151, 13);
            this.TcpClientLog.Name = "TcpClientLog";
            this.TcpClientLog.Size = new System.Drawing.Size(189, 171);
            this.TcpClientLog.TabIndex = 13;
            this.TcpClientLog.Text = "";
            // 
            // TcpDisconnect
            // 
            this.TcpDisconnect.Location = new System.Drawing.Point(9, 94);
            this.TcpDisconnect.Name = "TcpDisconnect";
            this.TcpDisconnect.Size = new System.Drawing.Size(136, 23);
            this.TcpDisconnect.TabIndex = 12;
            this.TcpDisconnect.Text = "Disconnect";
            this.TcpDisconnect.UseVisualStyleBackColor = true;
            this.TcpDisconnect.Click += new System.EventHandler(this.TcpDisconnect_Click);
            // 
            // TcpConnect
            // 
            this.TcpConnect.Location = new System.Drawing.Point(9, 65);
            this.TcpConnect.Name = "TcpConnect";
            this.TcpConnect.Size = new System.Drawing.Size(136, 23);
            this.TcpConnect.TabIndex = 11;
            this.TcpConnect.Text = "Connect";
            this.TcpConnect.UseVisualStyleBackColor = true;
            this.TcpConnect.Click += new System.EventHandler(this.TcpConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port";
            // 
            // TcpClientPort
            // 
            this.TcpClientPort.Location = new System.Drawing.Point(45, 39);
            this.TcpClientPort.Name = "TcpClientPort";
            this.TcpClientPort.Size = new System.Drawing.Size(100, 20);
            this.TcpClientPort.TabIndex = 9;
            this.TcpClientPort.Text = "5400";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP";
            // 
            // TcpClientIP
            // 
            this.TcpClientIP.Location = new System.Drawing.Point(45, 13);
            this.TcpClientIP.Name = "TcpClientIP";
            this.TcpClientIP.Size = new System.Drawing.Size(100, 20);
            this.TcpClientIP.TabIndex = 7;
            this.TcpClientIP.Text = "127.0.0.1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UdpSend);
            this.groupBox3.Controls.Add(this.UdpData);
            this.groupBox3.Controls.Add(this.UdpClientLog);
            this.groupBox3.Controls.Add(this.UdpDisconnect);
            this.groupBox3.Controls.Add(this.UdpConnect);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.UdpClientPort);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.UdpClientIP);
            this.groupBox3.Location = new System.Drawing.Point(364, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 196);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UdpClient";
            // 
            // UdpSend
            // 
            this.UdpSend.Location = new System.Drawing.Point(9, 149);
            this.UdpSend.Name = "UdpSend";
            this.UdpSend.Size = new System.Drawing.Size(136, 23);
            this.UdpSend.TabIndex = 17;
            this.UdpSend.Text = "Send";
            this.UdpSend.UseVisualStyleBackColor = true;
            this.UdpSend.Click += new System.EventHandler(this.UdpSend_Click);
            // 
            // UdpData
            // 
            this.UdpData.Location = new System.Drawing.Point(9, 123);
            this.UdpData.Name = "UdpData";
            this.UdpData.Size = new System.Drawing.Size(136, 20);
            this.UdpData.TabIndex = 16;
            // 
            // UdpClientLog
            // 
            this.UdpClientLog.Location = new System.Drawing.Point(151, 13);
            this.UdpClientLog.Name = "UdpClientLog";
            this.UdpClientLog.Size = new System.Drawing.Size(189, 171);
            this.UdpClientLog.TabIndex = 13;
            this.UdpClientLog.Text = "";
            // 
            // UdpDisconnect
            // 
            this.UdpDisconnect.Location = new System.Drawing.Point(9, 94);
            this.UdpDisconnect.Name = "UdpDisconnect";
            this.UdpDisconnect.Size = new System.Drawing.Size(136, 23);
            this.UdpDisconnect.TabIndex = 12;
            this.UdpDisconnect.Text = "Disconnect";
            this.UdpDisconnect.UseVisualStyleBackColor = true;
            this.UdpDisconnect.Click += new System.EventHandler(this.UdpDisconnect_Click);
            // 
            // UdpConnect
            // 
            this.UdpConnect.Location = new System.Drawing.Point(9, 65);
            this.UdpConnect.Name = "UdpConnect";
            this.UdpConnect.Size = new System.Drawing.Size(136, 23);
            this.UdpConnect.TabIndex = 11;
            this.UdpConnect.Text = "Connect";
            this.UdpConnect.UseVisualStyleBackColor = true;
            this.UdpConnect.Click += new System.EventHandler(this.UdpConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port";
            // 
            // UdpClientPort
            // 
            this.UdpClientPort.Location = new System.Drawing.Point(45, 39);
            this.UdpClientPort.Name = "UdpClientPort";
            this.UdpClientPort.Size = new System.Drawing.Size(100, 20);
            this.UdpClientPort.TabIndex = 9;
            this.UdpClientPort.Text = "5401";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "IP";
            // 
            // UdpClientIP
            // 
            this.UdpClientIP.Location = new System.Drawing.Point(45, 13);
            this.UdpClientIP.Name = "UdpClientIP";
            this.UdpClientIP.Size = new System.Drawing.Size(100, 20);
            this.UdpClientIP.TabIndex = 7;
            this.UdpClientIP.Text = "127.0.0.1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UdpServerLog);
            this.groupBox4.Controls.Add(this.UdpStop);
            this.groupBox4.Controls.Add(this.UdpStart);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.UdpServerPort);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.UdpServerIP);
            this.groupBox4.Location = new System.Drawing.Point(364, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 196);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UdpServer";
            // 
            // UdpServerLog
            // 
            this.UdpServerLog.Location = new System.Drawing.Point(151, 19);
            this.UdpServerLog.Name = "UdpServerLog";
            this.UdpServerLog.Size = new System.Drawing.Size(189, 171);
            this.UdpServerLog.TabIndex = 6;
            this.UdpServerLog.Text = "";
            // 
            // UdpStop
            // 
            this.UdpStop.Location = new System.Drawing.Point(9, 100);
            this.UdpStop.Name = "UdpStop";
            this.UdpStop.Size = new System.Drawing.Size(136, 23);
            this.UdpStop.TabIndex = 5;
            this.UdpStop.Text = "Stop";
            this.UdpStop.UseVisualStyleBackColor = true;
            this.UdpStop.Click += new System.EventHandler(this.UdpStop_Click);
            // 
            // UdpStart
            // 
            this.UdpStart.Location = new System.Drawing.Point(9, 71);
            this.UdpStart.Name = "UdpStart";
            this.UdpStart.Size = new System.Drawing.Size(136, 23);
            this.UdpStart.TabIndex = 4;
            this.UdpStart.Text = "Start";
            this.UdpStart.UseVisualStyleBackColor = true;
            this.UdpStart.Click += new System.EventHandler(this.UdpStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Port";
            // 
            // UdpServerPort
            // 
            this.UdpServerPort.Location = new System.Drawing.Point(45, 45);
            this.UdpServerPort.Name = "UdpServerPort";
            this.UdpServerPort.Size = new System.Drawing.Size(100, 20);
            this.UdpServerPort.TabIndex = 2;
            this.UdpServerPort.Text = "5401";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "IP";
            // 
            // UdpServerIP
            // 
            this.UdpServerIP.Location = new System.Drawing.Point(45, 19);
            this.UdpServerIP.Name = "UdpServerIP";
            this.UdpServerIP.Size = new System.Drawing.Size(100, 20);
            this.UdpServerIP.TabIndex = 0;
            this.UdpServerIP.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TcpServerIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TcpServerPort;
        private System.Windows.Forms.Button TcpStart;
        private System.Windows.Forms.Button TcpStop;
        private System.Windows.Forms.RichTextBox TcpServerLog;
        private System.Windows.Forms.RichTextBox TcpClientLog;
        private System.Windows.Forms.Button TcpDisconnect;
        private System.Windows.Forms.Button TcpConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TcpClientPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TcpClientIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox UdpClientLog;
        private System.Windows.Forms.Button UdpDisconnect;
        private System.Windows.Forms.Button UdpConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UdpClientPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UdpClientIP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox UdpServerLog;
        private System.Windows.Forms.Button UdpStop;
        private System.Windows.Forms.Button UdpStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UdpServerPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UdpServerIP;
        private System.Windows.Forms.Button TcpSend;
        private System.Windows.Forms.TextBox TcpData;
        private System.Windows.Forms.Button UdpSend;
        private System.Windows.Forms.TextBox UdpData;
    }
}

