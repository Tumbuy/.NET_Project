namespace Chat_Client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.client1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP_C1 = new System.Windows.Forms.TextBox();
            this.txtPort_C1 = new System.Windows.Forms.TextBox();
            this.client2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP_C2 = new System.Windows.Forms.TextBox();
            this.txtPort_C2 = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.client1.SuspendLayout();
            this.client2.SuspendLayout();
            this.SuspendLayout();
            // 
            // client1
            // 
            this.client1.Controls.Add(this.label2);
            this.client1.Controls.Add(this.label1);
            this.client1.Controls.Add(this.txtIP_C1);
            this.client1.Controls.Add(this.txtPort_C1);
            this.client1.Location = new System.Drawing.Point(12, 12);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(183, 100);
            this.client1.TabIndex = 0;
            this.client1.TabStop = false;
            this.client1.Text = "YOU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txtIP_C1
            // 
            this.txtIP_C1.Location = new System.Drawing.Point(50, 22);
            this.txtIP_C1.Name = "txtIP_C1";
            this.txtIP_C1.Size = new System.Drawing.Size(100, 20);
            this.txtIP_C1.TabIndex = 1;
            // 
            // txtPort_C1
            // 
            this.txtPort_C1.Location = new System.Drawing.Point(50, 48);
            this.txtPort_C1.Name = "txtPort_C1";
            this.txtPort_C1.Size = new System.Drawing.Size(100, 20);
            this.txtPort_C1.TabIndex = 0;
            // 
            // client2
            // 
            this.client2.Controls.Add(this.label3);
            this.client2.Controls.Add(this.label4);
            this.client2.Controls.Add(this.txtIP_C2);
            this.client2.Controls.Add(this.txtPort_C2);
            this.client2.Location = new System.Drawing.Point(201, 12);
            this.client2.Name = "client2";
            this.client2.Size = new System.Drawing.Size(177, 100);
            this.client2.TabIndex = 0;
            this.client2.TabStop = false;
            this.client2.Text = "FRIEND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port:";
            // 
            // txtIP_C2
            // 
            this.txtIP_C2.Location = new System.Drawing.Point(50, 22);
            this.txtIP_C2.Name = "txtIP_C2";
            this.txtIP_C2.Size = new System.Drawing.Size(100, 20);
            this.txtIP_C2.TabIndex = 3;
            // 
            // txtPort_C2
            // 
            this.txtPort_C2.Location = new System.Drawing.Point(50, 48);
            this.txtPort_C2.Name = "txtPort_C2";
            this.txtPort_C2.Size = new System.Drawing.Size(100, 20);
            this.txtPort_C2.TabIndex = 2;
            // 
            // listMessage
            // 
            this.listMessage.HorizontalScrollbar = true;
            this.listMessage.Location = new System.Drawing.Point(12, 118);
            this.listMessage.Name = "listMessage";
            this.listMessage.ScrollAlwaysVisible = true;
            this.listMessage.Size = new System.Drawing.Size(447, 173);
            this.listMessage.Sorted = true;
            this.listMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(465, 297);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(465, 89);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 297);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(447, 20);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Googooli - Chat";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Googooli - Chat";
            this.notifyIcon1.Visible = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(384, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(63, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show IPs";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(453, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 69);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 332);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.client2);
            this.Controls.Add(this.client1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Googooli - Chat";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.client1.ResumeLayout(false);
            this.client1.PerformLayout();
            this.client2.ResumeLayout(false);
            this.client2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox client1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP_C1;
        private System.Windows.Forms.TextBox txtPort_C1;
        private System.Windows.Forms.GroupBox client2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP_C2;
        private System.Windows.Forms.TextBox txtPort_C2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        public System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox listBox1;
    }
}

