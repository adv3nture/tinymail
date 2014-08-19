namespace TinyMail
{
    partial class AddressBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressBookForm));
            this.selectedContact = new System.Windows.Forms.TextBox();
            this.newContactBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addressLab = new System.Windows.Forms.Label();
            this.nameLab = new System.Windows.Forms.Label();
            this.contactListView = new System.Windows.Forms.ListView();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.deleteContactBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedContact
            // 
            this.selectedContact.Enabled = false;
            this.selectedContact.Location = new System.Drawing.Point(14, 357);
            this.selectedContact.Name = "selectedContact";
            this.selectedContact.Size = new System.Drawing.Size(425, 23);
            this.selectedContact.TabIndex = 1;
            // 
            // newContactBtn
            // 
            this.newContactBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newContactBtn.Location = new System.Drawing.Point(592, 19);
            this.newContactBtn.Name = "newContactBtn";
            this.newContactBtn.Size = new System.Drawing.Size(112, 53);
            this.newContactBtn.TabIndex = 3;
            this.newContactBtn.Text = "Add New";
            this.newContactBtn.UseVisualStyleBackColor = true;
            this.newContactBtn.Click += new System.EventHandler(this.newContactBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.addressLab);
            this.groupBox1.Controls.Add(this.nameLab);
            this.groupBox1.Controls.Add(this.newContactBtn);
            this.groupBox1.Location = new System.Drawing.Point(15, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Contact";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(64, 49);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(522, 23);
            this.addressTxt.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(64, 19);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(522, 23);
            this.nameTxt.TabIndex = 1;
            // 
            // addressLab
            // 
            this.addressLab.AutoSize = true;
            this.addressLab.Location = new System.Drawing.Point(6, 52);
            this.addressLab.Name = "addressLab";
            this.addressLab.Size = new System.Drawing.Size(52, 15);
            this.addressLab.TabIndex = 4;
            this.addressLab.Text = "Address:";
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(6, 22);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(42, 15);
            this.nameLab.TabIndex = 3;
            this.nameLab.Text = "Name:";
            // 
            // contactListView
            // 
            this.contactListView.Location = new System.Drawing.Point(14, 12);
            this.contactListView.Name = "contactListView";
            this.contactListView.Size = new System.Drawing.Size(714, 339);
            this.contactListView.TabIndex = 0;
            this.contactListView.UseCompatibleStateImageBehavior = false;
            this.contactListView.View = System.Windows.Forms.View.List;
            this.contactListView.ItemActivate += new System.EventHandler(this.contactListView_ItemActivate);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(526, 357);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(445, 357);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // deleteContactBtn
            // 
            this.deleteContactBtn.Location = new System.Drawing.Point(607, 357);
            this.deleteContactBtn.Name = "deleteContactBtn";
            this.deleteContactBtn.Size = new System.Drawing.Size(121, 23);
            this.deleteContactBtn.TabIndex = 6;
            this.deleteContactBtn.Text = "Delete All Contacts";
            this.deleteContactBtn.UseVisualStyleBackColor = true;
            this.deleteContactBtn.Click += new System.EventHandler(this.deleteContactBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 479);
            this.Controls.Add(this.deleteContactBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.contactListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectedContact);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressBookForm";
            this.Text = "TinyMail - Address Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedContact;
        private System.Windows.Forms.Button newContactBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label addressLab;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.ListView contactListView;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button deleteContactBtn;
        private System.Windows.Forms.Timer timer1;
    }
}