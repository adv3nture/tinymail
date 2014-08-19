namespace TinyMail
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
            this.toTxt = new System.Windows.Forms.TextBox();
            this.bodyTxt = new System.Windows.Forms.TextBox();
            this.subTxt = new System.Windows.Forms.TextBox();
            this.toLab = new System.Windows.Forms.Label();
            this.subLab = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.fromTxt = new System.Windows.Forms.TextBox();
            this.fromLab = new System.Windows.Forms.Label();
            this.smtpLab = new System.Windows.Forms.Label();
            this.smtpTxt = new System.Windows.Forms.TextBox();
            this.passLab = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rememberCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ccLab = new System.Windows.Forms.Label();
            this.ccTxt = new System.Windows.Forms.TextBox();
            this.bccTxt = new System.Windows.Forms.TextBox();
            this.bccLab = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.attachBtn = new System.Windows.Forms.Button();
            this.attachLab = new System.Windows.Forms.Label();
            this.clearAttachBtn = new System.Windows.Forms.Button();
            this.clearCredsBtn = new System.Windows.Forms.Button();
            this.clearMessageBtn = new System.Windows.Forms.Button();
            this.sendNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.deleteDataBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toTxt
            // 
            this.toTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toTxt.Location = new System.Drawing.Point(67, 12);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(925, 23);
            this.toTxt.TabIndex = 0;
            // 
            // bodyTxt
            // 
            this.bodyTxt.Location = new System.Drawing.Point(15, 117);
            this.bodyTxt.Multiline = true;
            this.bodyTxt.Name = "bodyTxt";
            this.bodyTxt.Size = new System.Drawing.Size(977, 300);
            this.bodyTxt.TabIndex = 6;
            // 
            // subTxt
            // 
            this.subTxt.Location = new System.Drawing.Point(67, 41);
            this.subTxt.Name = "subTxt";
            this.subTxt.Size = new System.Drawing.Size(925, 23);
            this.subTxt.TabIndex = 1;
            // 
            // toLab
            // 
            this.toLab.AutoSize = true;
            this.toLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toLab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLab.Location = new System.Drawing.Point(12, 14);
            this.toLab.Name = "toLab";
            this.toLab.Size = new System.Drawing.Size(24, 15);
            this.toLab.TabIndex = 3;
            this.toLab.Text = "To:";
            this.toLab.Click += new System.EventHandler(this.toLab_Click);
            // 
            // subLab
            // 
            this.subLab.AutoSize = true;
            this.subLab.Location = new System.Drawing.Point(12, 44);
            this.subLab.Name = "subLab";
            this.subLab.Size = new System.Drawing.Size(49, 15);
            this.subLab.TabIndex = 4;
            this.subLab.Text = "Subject:";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(896, 13);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 40);
            this.sendBtn.TabIndex = 10;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // fromTxt
            // 
            this.fromTxt.Location = new System.Drawing.Point(50, 22);
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(287, 23);
            this.fromTxt.TabIndex = 7;
            this.fromTxt.TextChanged += new System.EventHandler(this.fromTxt_TextChanged);
            // 
            // fromLab
            // 
            this.fromLab.AutoSize = true;
            this.fromLab.Location = new System.Drawing.Point(6, 27);
            this.fromLab.Name = "fromLab";
            this.fromLab.Size = new System.Drawing.Size(38, 15);
            this.fromLab.TabIndex = 8;
            this.fromLab.Text = "From:";
            // 
            // smtpLab
            // 
            this.smtpLab.AutoSize = true;
            this.smtpLab.Location = new System.Drawing.Point(621, 25);
            this.smtpLab.Name = "smtpLab";
            this.smtpLab.Size = new System.Drawing.Size(69, 15);
            this.smtpLab.TabIndex = 9;
            this.smtpLab.Text = "SMTP Host:";
            // 
            // smtpTxt
            // 
            this.smtpTxt.Location = new System.Drawing.Point(696, 22);
            this.smtpTxt.Name = "smtpTxt";
            this.smtpTxt.Size = new System.Drawing.Size(194, 23);
            this.smtpTxt.TabIndex = 9;
            // 
            // passLab
            // 
            this.passLab.AutoSize = true;
            this.passLab.Location = new System.Drawing.Point(343, 25);
            this.passLab.Name = "passLab";
            this.passLab.Size = new System.Drawing.Size(60, 15);
            this.passLab.TabIndex = 11;
            this.passLab.Text = "Password:";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(409, 22);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(206, 23);
            this.passTxt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rememberCheck);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fromLab);
            this.groupBox1.Controls.Add(this.sendBtn);
            this.groupBox1.Controls.Add(this.smtpTxt);
            this.groupBox1.Controls.Add(this.passTxt);
            this.groupBox1.Controls.Add(this.smtpLab);
            this.groupBox1.Controls.Add(this.fromTxt);
            this.groupBox1.Controls.Add(this.passLab);
            this.groupBox1.Location = new System.Drawing.Point(15, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender Credentials";
            // 
            // rememberCheck
            // 
            this.rememberCheck.AutoSize = true;
            this.rememberCheck.Location = new System.Drawing.Point(118, 0);
            this.rememberCheck.Name = "rememberCheck";
            this.rememberCheck.Size = new System.Drawing.Size(104, 19);
            this.rememberCheck.TabIndex = 20;
            this.rememberCheck.Text = "Remember Me";
            this.rememberCheck.UseVisualStyleBackColor = true;
            this.rememberCheck.CheckedChanged += new System.EventHandler(this.rememberCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "What\'s This?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ccLab
            // 
            this.ccLab.AutoSize = true;
            this.ccLab.Location = new System.Drawing.Point(12, 73);
            this.ccLab.Name = "ccLab";
            this.ccLab.Size = new System.Drawing.Size(24, 15);
            this.ccLab.TabIndex = 14;
            this.ccLab.Text = "Cc:";
            // 
            // ccTxt
            // 
            this.ccTxt.Location = new System.Drawing.Point(67, 70);
            this.ccTxt.Name = "ccTxt";
            this.ccTxt.Size = new System.Drawing.Size(396, 23);
            this.ccTxt.TabIndex = 2;
            // 
            // bccTxt
            // 
            this.bccTxt.Location = new System.Drawing.Point(504, 70);
            this.bccTxt.Name = "bccTxt";
            this.bccTxt.Size = new System.Drawing.Size(396, 23);
            this.bccTxt.TabIndex = 3;
            // 
            // bccLab
            // 
            this.bccLab.AutoSize = true;
            this.bccLab.Location = new System.Drawing.Point(469, 73);
            this.bccLab.Name = "bccLab";
            this.bccLab.Size = new System.Drawing.Size(29, 15);
            this.bccLab.TabIndex = 16;
            this.bccLab.Text = "Bcc:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // attachBtn
            // 
            this.attachBtn.Location = new System.Drawing.Point(907, 69);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(86, 24);
            this.attachBtn.TabIndex = 5;
            this.attachBtn.Text = "Attach Files";
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // attachLab
            // 
            this.attachLab.AutoSize = true;
            this.attachLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attachLab.ForeColor = System.Drawing.Color.Navy;
            this.attachLab.Location = new System.Drawing.Point(15, 96);
            this.attachLab.Name = "attachLab";
            this.attachLab.Size = new System.Drawing.Size(116, 17);
            this.attachLab.TabIndex = 18;
            this.attachLab.Text = "Attachments: NONE";
            // 
            // clearAttachBtn
            // 
            this.clearAttachBtn.Location = new System.Drawing.Point(15, 489);
            this.clearAttachBtn.Name = "clearAttachBtn";
            this.clearAttachBtn.Size = new System.Drawing.Size(131, 23);
            this.clearAttachBtn.TabIndex = 11;
            this.clearAttachBtn.Text = "Clear Attachments";
            this.clearAttachBtn.UseVisualStyleBackColor = true;
            this.clearAttachBtn.Click += new System.EventHandler(this.clearAttachBtn_Click);
            // 
            // clearCredsBtn
            // 
            this.clearCredsBtn.Location = new System.Drawing.Point(152, 489);
            this.clearCredsBtn.Name = "clearCredsBtn";
            this.clearCredsBtn.Size = new System.Drawing.Size(131, 23);
            this.clearCredsBtn.TabIndex = 12;
            this.clearCredsBtn.Text = "Clear Credentials";
            this.clearCredsBtn.UseVisualStyleBackColor = true;
            this.clearCredsBtn.Click += new System.EventHandler(this.clearCredsBtn_Click);
            // 
            // clearMessageBtn
            // 
            this.clearMessageBtn.Location = new System.Drawing.Point(289, 489);
            this.clearMessageBtn.Name = "clearMessageBtn";
            this.clearMessageBtn.Size = new System.Drawing.Size(131, 23);
            this.clearMessageBtn.TabIndex = 13;
            this.clearMessageBtn.Text = "Clear Message";
            this.clearMessageBtn.UseVisualStyleBackColor = true;
            this.clearMessageBtn.Click += new System.EventHandler(this.clearMessageBtn_Click);
            // 
            // sendNotify
            // 
            this.sendNotify.BalloonTipTitle = "TinyMail: Message Sent!";
            this.sendNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("sendNotify.Icon")));
            this.sendNotify.Text = "TinyMail - Running";
            this.sendNotify.Visible = true;
            // 
            // deleteDataBtn
            // 
            this.deleteDataBtn.Location = new System.Drawing.Point(876, 489);
            this.deleteDataBtn.Name = "deleteDataBtn";
            this.deleteDataBtn.Size = new System.Drawing.Size(117, 23);
            this.deleteDataBtn.TabIndex = 20;
            this.deleteDataBtn.Text = "Delete All Data";
            this.deleteDataBtn.UseVisualStyleBackColor = true;
            this.deleteDataBtn.Click += new System.EventHandler(this.deleteDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 518);
            this.Controls.Add(this.deleteDataBtn);
            this.Controls.Add(this.clearMessageBtn);
            this.Controls.Add(this.clearCredsBtn);
            this.Controls.Add(this.clearAttachBtn);
            this.Controls.Add(this.attachLab);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.bccTxt);
            this.Controls.Add(this.bccLab);
            this.Controls.Add(this.ccTxt);
            this.Controls.Add(this.ccLab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.subLab);
            this.Controls.Add(this.toLab);
            this.Controls.Add(this.subTxt);
            this.Controls.Add(this.bodyTxt);
            this.Controls.Add(this.toTxt);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TinyMail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bodyTxt;
        private System.Windows.Forms.TextBox subTxt;
        private System.Windows.Forms.Label toLab;
        private System.Windows.Forms.Label subLab;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox fromTxt;
        private System.Windows.Forms.Label fromLab;
        private System.Windows.Forms.Label smtpLab;
        private System.Windows.Forms.TextBox smtpTxt;
        private System.Windows.Forms.Label passLab;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ccLab;
        private System.Windows.Forms.TextBox ccTxt;
        private System.Windows.Forms.TextBox bccTxt;
        private System.Windows.Forms.Label bccLab;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.Label attachLab;
        private System.Windows.Forms.Button clearAttachBtn;
        private System.Windows.Forms.Button clearCredsBtn;
        private System.Windows.Forms.Button clearMessageBtn;
        private System.Windows.Forms.NotifyIcon sendNotify;
        public System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.CheckBox rememberCheck;
        private System.Windows.Forms.Button deleteDataBtn;
    }
}

