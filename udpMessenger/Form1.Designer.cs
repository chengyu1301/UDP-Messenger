namespace udpMessenger
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.Halt = new System.Windows.Forms.Button();
            this.buttonStartListening = new System.Windows.Forms.Button();
            this.textBoxListeningPort = new System.Windows.Forms.TextBox();
            this.textBoxTargetPort = new System.Windows.Forms.TextBox();
            this.textBoxMessageSend = new System.Windows.Forms.TextBox();
            this.textBoxTargetIP = new System.Windows.Forms.TextBox();
            this.labelListeningPort = new System.Windows.Forms.Label();
            this.labelMessageReceived = new System.Windows.Forms.Label();
            this.labelTargetIP = new System.Windows.Forms.Label();
            this.labelMessageSend = new System.Windows.Forms.Label();
            this.richTextBoxMessageReceived = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelTargetPort = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxListeningPort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTargetPort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMessageSend, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTargetIP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelListeningPort, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMessageReceived, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelTargetIP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMessageSend, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxMessageReceived, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSend, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelTargetPort, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 384);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.Halt);
            this.panel1.Controls.Add(this.buttonStartListening);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(153, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 64);
            this.panel1.TabIndex = 32;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(3, 19);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(175, 25);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.Text = "Unknown";
            // 
            // Halt
            // 
            this.Halt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Halt.AutoSize = true;
            this.Halt.Location = new System.Drawing.Point(307, 9);
            this.Halt.Name = "Halt";
            this.Halt.Size = new System.Drawing.Size(74, 55);
            this.Halt.TabIndex = 30;
            this.Halt.Text = "Halt";
            this.Halt.UseVisualStyleBackColor = true;
            this.Halt.Click += new System.EventHandler(this.Halt_Click);
            // 
            // buttonStartListening
            // 
            this.buttonStartListening.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonStartListening.AutoSize = true;
            this.buttonStartListening.Location = new System.Drawing.Point(216, 9);
            this.buttonStartListening.Name = "buttonStartListening";
            this.buttonStartListening.Size = new System.Drawing.Size(72, 55);
            this.buttonStartListening.TabIndex = 6;
            this.buttonStartListening.Text = "Start\r\nListening\r\n";
            this.buttonStartListening.UseVisualStyleBackColor = true;
            // 
            // textBoxListeningPort
            // 
            this.textBoxListeningPort.Location = new System.Drawing.Point(153, 73);
            this.textBoxListeningPort.Name = "textBoxListeningPort";
            this.textBoxListeningPort.Size = new System.Drawing.Size(70, 25);
            this.textBoxListeningPort.TabIndex = 1;
            this.textBoxListeningPort.Text = "9002";
            this.textBoxListeningPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxListeningPort_KeyPress);
            // 
            // textBoxTargetPort
            // 
            this.textBoxTargetPort.Location = new System.Drawing.Point(153, 108);
            this.textBoxTargetPort.Name = "textBoxTargetPort";
            this.textBoxTargetPort.Size = new System.Drawing.Size(70, 25);
            this.textBoxTargetPort.TabIndex = 3;
            this.textBoxTargetPort.Text = "9001";
            this.textBoxTargetPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTargetPort_KeyPress);
            // 
            // textBoxMessageSend
            // 
            this.textBoxMessageSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessageSend.Location = new System.Drawing.Point(153, 354);
            this.textBoxMessageSend.Name = "textBoxMessageSend";
            this.textBoxMessageSend.Size = new System.Drawing.Size(467, 25);
            this.textBoxMessageSend.TabIndex = 12;
            this.textBoxMessageSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessageSend_KeyPress);
            // 
            // textBoxTargetIP
            // 
            this.textBoxTargetIP.Location = new System.Drawing.Point(153, 143);
            this.textBoxTargetIP.Name = "textBoxTargetIP";
            this.textBoxTargetIP.Size = new System.Drawing.Size(114, 25);
            this.textBoxTargetIP.TabIndex = 5;
            this.textBoxTargetIP.Text = "127.0.0.1";
            this.textBoxTargetIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTargetIP_KeyPress);
            // 
            // labelListeningPort
            // 
            this.labelListeningPort.AutoSize = true;
            this.labelListeningPort.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeningPort.Location = new System.Drawing.Point(3, 70);
            this.labelListeningPort.Name = "labelListeningPort";
            this.labelListeningPort.Size = new System.Drawing.Size(137, 23);
            this.labelListeningPort.TabIndex = 0;
            this.labelListeningPort.Text = "Listening Port:";
            // 
            // labelMessageReceived
            // 
            this.labelMessageReceived.AutoSize = true;
            this.labelMessageReceived.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageReceived.Location = new System.Drawing.Point(3, 175);
            this.labelMessageReceived.Name = "labelMessageReceived";
            this.labelMessageReceived.Size = new System.Drawing.Size(93, 46);
            this.labelMessageReceived.TabIndex = 6;
            this.labelMessageReceived.Text = "Message \r\nReceived:";
            // 
            // labelTargetIP
            // 
            this.labelTargetIP.AutoSize = true;
            this.labelTargetIP.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetIP.Location = new System.Drawing.Point(3, 140);
            this.labelTargetIP.Name = "labelTargetIP";
            this.labelTargetIP.Size = new System.Drawing.Size(91, 23);
            this.labelTargetIP.TabIndex = 4;
            this.labelTargetIP.Text = "Target IP:";
            // 
            // labelMessageSend
            // 
            this.labelMessageSend.AutoSize = true;
            this.labelMessageSend.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageSend.Location = new System.Drawing.Point(3, 351);
            this.labelMessageSend.Name = "labelMessageSend";
            this.labelMessageSend.Size = new System.Drawing.Size(135, 23);
            this.labelMessageSend.TabIndex = 8;
            this.labelMessageSend.Text = "Message Send:";
            // 
            // richTextBoxMessageReceived
            // 
            this.richTextBoxMessageReceived.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxMessageReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMessageReceived.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBoxMessageReceived.Location = new System.Drawing.Point(153, 178);
            this.richTextBoxMessageReceived.Name = "richTextBoxMessageReceived";
            this.richTextBoxMessageReceived.ReadOnly = true;
            this.richTextBoxMessageReceived.Size = new System.Drawing.Size(467, 170);
            this.richTextBoxMessageReceived.TabIndex = 11;
            this.richTextBoxMessageReceived.Text = "";
            this.richTextBoxMessageReceived.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxMessageReceived_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUserName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 64);
            this.panel2.TabIndex = 33;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(3, 19);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(110, 23);
            this.labelUserName.TabIndex = 18;
            this.labelUserName.Text = "User Name:";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Cambria", 10F);
            this.buttonSend.Location = new System.Drawing.Point(626, 354);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(78, 27);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelTargetPort
            // 
            this.labelTargetPort.AutoSize = true;
            this.labelTargetPort.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargetPort.Location = new System.Drawing.Point(3, 105);
            this.labelTargetPort.Name = "labelTargetPort";
            this.labelTargetPort.Size = new System.Drawing.Size(111, 23);
            this.labelTargetPort.TabIndex = 2;
            this.labelTargetPort.Text = "Target Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "UDP Messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button Halt;
        private System.Windows.Forms.Button buttonStartListening;
        private System.Windows.Forms.TextBox textBoxListeningPort;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxTargetPort;
        private System.Windows.Forms.TextBox textBoxMessageSend;
        private System.Windows.Forms.RichTextBox richTextBoxMessageReceived;
        private System.Windows.Forms.TextBox textBoxTargetIP;
        private System.Windows.Forms.Label labelListeningPort;
        private System.Windows.Forms.Label labelMessageReceived;
        private System.Windows.Forms.Label labelTargetPort;
        private System.Windows.Forms.Label labelTargetIP;
        private System.Windows.Forms.Label labelMessageSend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUserName;


    }
}

