using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TinyMail
{
    public partial class AddressBookForm : Form
    {
        public Form1 mainForm;

        public AddressBookForm()
        {
            InitializeComponent();

            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }

            if (!File.Exists("data\\contacts.tm"))
            {
                File.Create("data\\contacts.tm").Close();
            }

            StreamReader fileIn = new StreamReader("data\\contacts.tm");

            int countLines = 0;
            string contactIn;

            while ((contactIn = fileIn.ReadLine()) != null)
            {
                contactListView.Items.Add(contactIn);
                countLines++;
            }

            fileIn.Close();
        }

        private void newContactBtn_Click(object sender, EventArgs e)
        {
            contactListView.Items.Add(nameTxt.Text + ";" + addressTxt.Text);

            string contact = nameTxt.Text + ";" + addressTxt.Text;

            nameTxt.Clear();
            addressTxt.Clear();

            using (StreamWriter fileOut = File.AppendText("data\\contacts.tm"))
            {
                fileOut.WriteLineAsync(contact);
                fileOut.Close();
            }
        }

        private void contactListView_ItemActivate(object sender, EventArgs e)
        {
            string cString = contactListView.FocusedItem.Text;
            string[] address = cString.Split(';');

            selectedContact.Text = address[1];
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            selectedContact.Clear();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            //mainForm.toTxt.Text = selectedContact.Text;

            this.Close();
        }

        private void deleteContactBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("data\\contacts.tm"))
            {
                DialogResult sureBox = MessageBox.Show("This will remove all of your contacts. Continue?", "Are you sure?", MessageBoxButtons.YesNo);

                if (sureBox == DialogResult.Yes)
                {
                    File.Delete("data\\contacts.tm");
                    selectedContact.Clear();
                    contactListView.Clear();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nameTxt.Text.Trim().Length > 0 && addressTxt.Text.Trim().Length > 0)
            {
                newContactBtn.Enabled = true;
            }

            else
            {
                newContactBtn.Enabled = false;
            }
        }
    }
}
