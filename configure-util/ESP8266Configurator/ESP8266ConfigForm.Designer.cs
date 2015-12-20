namespace ESP8266Configurator
{
    partial class ESP8266ConfigForm
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
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.lblSSID = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRemoteIp = new System.Windows.Forms.Label();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.txtRemoteIp1 = new System.Windows.Forms.MaskedTextBox();
            this.txtRemotePort = new System.Windows.Forms.MaskedTextBox();
            this.txtRemoteIp2 = new System.Windows.Forms.MaskedTextBox();
            this.txtRemoteIp3 = new System.Windows.Forms.MaskedTextBox();
            this.txtRemoteIp4 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPort
            // 
            this.cmbPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(216, 20);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(183, 21);
            this.cmbPort.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(16, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(194, 18);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Select Serial port to connect:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSSID
            // 
            this.txtSSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSSID.Location = new System.Drawing.Point(216, 57);
            this.txtSSID.MaxLength = 32;
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(183, 20);
            this.txtSSID.TabIndex = 2;
            // 
            // lblSSID
            // 
            this.lblSSID.Location = new System.Drawing.Point(19, 60);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(191, 20);
            this.lblSSID.TabIndex = 3;
            this.lblSSID.Text = "SSID:";
            this.lblSSID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(19, 86);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(191, 20);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(216, 83);
            this.txtPassword.MaxLength = 64;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblRemoteIp
            // 
            this.lblRemoteIp.Location = new System.Drawing.Point(19, 112);
            this.lblRemoteIp.Name = "lblRemoteIp";
            this.lblRemoteIp.Size = new System.Drawing.Size(191, 20);
            this.lblRemoteIp.TabIndex = 7;
            this.lblRemoteIp.Text = "Remote IP (to connect to):";
            this.lblRemoteIp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.Location = new System.Drawing.Point(19, 141);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(191, 20);
            this.lblRemotePort.TabIndex = 9;
            this.lblRemotePort.Text = "Remote Port:";
            this.lblRemotePort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRemoteIp1
            // 
            this.txtRemoteIp1.Location = new System.Drawing.Point(216, 112);
            this.txtRemoteIp1.Mask = "###";
            this.txtRemoteIp1.Name = "txtRemoteIp1";
            this.txtRemoteIp1.PromptChar = ' ';
            this.txtRemoteIp1.Size = new System.Drawing.Size(29, 20);
            this.txtRemoteIp1.TabIndex = 10;
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(216, 138);
            this.txtRemotePort.Mask = "#####";
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.PromptChar = ' ';
            this.txtRemotePort.Size = new System.Drawing.Size(80, 20);
            this.txtRemotePort.TabIndex = 14;
            // 
            // txtRemoteIp2
            // 
            this.txtRemoteIp2.Location = new System.Drawing.Point(267, 112);
            this.txtRemoteIp2.Mask = "###";
            this.txtRemoteIp2.Name = "txtRemoteIp2";
            this.txtRemoteIp2.PromptChar = ' ';
            this.txtRemoteIp2.Size = new System.Drawing.Size(29, 20);
            this.txtRemoteIp2.TabIndex = 11;
            // 
            // txtRemoteIp3
            // 
            this.txtRemoteIp3.Location = new System.Drawing.Point(318, 112);
            this.txtRemoteIp3.Mask = "###";
            this.txtRemoteIp3.Name = "txtRemoteIp3";
            this.txtRemoteIp3.PromptChar = ' ';
            this.txtRemoteIp3.Size = new System.Drawing.Size(29, 20);
            this.txtRemoteIp3.TabIndex = 12;
            // 
            // txtRemoteIp4
            // 
            this.txtRemoteIp4.Location = new System.Drawing.Point(369, 112);
            this.txtRemoteIp4.Mask = "###";
            this.txtRemoteIp4.Name = "txtRemoteIp4";
            this.txtRemoteIp4.PromptChar = ' ';
            this.txtRemoteIp4.Size = new System.Drawing.Size(29, 20);
            this.txtRemoteIp4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = ".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = ".";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSetup
            // 
            this.btnSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetup.Location = new System.Drawing.Point(320, 173);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 18;
            this.btnSetup.Text = "Set it up !";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Location = new System.Drawing.Point(11, 236);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(388, 223);
            this.txtLog.TabIndex = 19;
            this.txtLog.Text = "";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(8, 220);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(99, 13);
            this.lblLog.TabIndex = 20;
            this.lblLog.Text = "Communication log:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatus.Location = new System.Drawing.Point(11, 173);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(118, 23);
            this.btnStatus.TabIndex = 21;
            this.btnStatus.Text = "Check Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // ESP8266ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 467);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemoteIp4);
            this.Controls.Add(this.txtRemoteIp3);
            this.Controls.Add(this.txtRemoteIp2);
            this.Controls.Add(this.txtRemotePort);
            this.Controls.Add(this.txtRemoteIp1);
            this.Controls.Add(this.lblRemotePort);
            this.Controls.Add(this.lblRemoteIp);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSSID);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cmbPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ESP8266ConfigForm";
            this.Text = "ESP8266 firmata Wifi Config";
            this.Load += new System.EventHandler(this.ESP8266ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.Label lblSSID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRemoteIp;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.MaskedTextBox txtRemoteIp1;
        private System.Windows.Forms.MaskedTextBox txtRemotePort;
        private System.Windows.Forms.MaskedTextBox txtRemoteIp2;
        private System.Windows.Forms.MaskedTextBox txtRemoteIp3;
        private System.Windows.Forms.MaskedTextBox txtRemoteIp4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStatus;
    }
}

