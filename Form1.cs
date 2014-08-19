using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace TinyMail
{
    public partial class Form1 : Form
    {
        public MailMessage message = new MailMessage();

        public Form1()
        {
            InitializeComponent();
        }

        static public string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;
        }

        static public string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);

            string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);

            return returnValue;
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();

            if (File.Exists("data\\contacts.tm"))
            {
                StreamReader fileIn = new StreamReader("data\\contacts.tm");

                int countLines = 0;
                string contactIn;

                while ((contactIn = fileIn.ReadLine()) != null)
                {
                    string[] contactInSplit = contactIn.Split(';');

                    autoCompleteData.Add(contactInSplit[1]);
                    countLines++;
                }

                fileIn.Close();

                toTxt.AutoCompleteCustomSource = autoCompleteData;

                if (File.Exists("data\\credentials.tm"))
                {
                    StreamReader readCreds = new StreamReader("data\\credentials.tm");

                    int lines = 0;
                    string credsIn;
                    List<string> credsList = new List<string>();

                    while ((credsIn = readCreds.ReadLine()) != null)
                    {
                        string deCreds = DecodeFrom64(credsIn);
                        credsList.Add(deCreds);
                        lines++;
                    }

                    readCreds.Close();

                    credsList.ToArray();

                    fromTxt.Text = credsList[0];
                    passTxt.Text = credsList[1];
                    smtpTxt.Text = credsList[2];

                    rememberCheck.Checked = true;
                }

                else
                {
                    rememberCheck.Checked = false;
                }
            }
        }

        public string sharedToTxt
        {
            get { return toTxt.Text; }
            set { toTxt.Text = value; }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient(smtpTxt.Text);

            client.Credentials = new NetworkCredential(fromTxt.Text, passTxt.Text);

            message.To.Add(toTxt.Text);

            if (ccTxt.Text.Trim().Length > 0)
                message.CC.Add(ccTxt.Text);

            if (bccTxt.Text.Trim().Length > 0)
                message.Bcc.Add(bccTxt.Text);

            message.From = new MailAddress(fromTxt.Text);

            message.Subject = subTxt.Text;
            message.Body = bodyTxt.Text;

            if (subTxt.Text.Trim().Length == 0)
            {
                DialogResult noSub = MessageBox.Show("Subject box is empty. Send anyway?", "This message has no subject", MessageBoxButtons.YesNo);

                if (noSub == DialogResult.Yes)
                {
                    try
                    {
                        client.SendAsync(message, null);
                        sendNotify.BalloonTipText = "Message to " + toTxt.Text + " has been sent.";
                        sendNotify.ShowBalloonTip(5000);

                        message.Attachments.Clear();
                        toTxt.Clear();
                        subTxt.Clear();
                        ccTxt.Clear();
                        bccTxt.Clear();
                        bodyTxt.Clear();
                    }

                    catch (SmtpException)
                    {
                        MessageBox.Show("There was en error sending that message! The email/password/server combination was incorrect. Please try again.", "Message send error");
                    }
                }
            }

            else
            {
                try
                {
                    client.SendAsync(message, null);
                    sendNotify.BalloonTipText = "Message to " + toTxt.Text + " has been sent.";
                    sendNotify.ShowBalloonTip(5000);

                    message.Attachments.Clear();
                    toTxt.Clear();
                    subTxt.Clear();
                    ccTxt.Clear();
                    bccTxt.Clear();
                    bodyTxt.Clear();
                }

                catch (SmtpException)
                {
                    MessageBox.Show("There was en error sending that message! The email/password/server combination was incorrect. Please try again.", "Message send error");
                }
            }
        }

        private void fromTxt_TextChanged(object sender, EventArgs e)
        {
            if (fromTxt.Text.Trim().Length > 0)
            {
                this.Text = "TinyMail - " + fromTxt.Text;
            }

            else
            {
                this.Text = "TinyMail";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (toTxt.Text.Trim().Length > 0 && fromTxt.Text.Trim().Length > 0 && passTxt.Text.Trim().Length > 0 && smtpTxt.Text.Trim().Length > 0)
            {
                sendBtn.Enabled = true;
            }

            else
            {
                sendBtn.Enabled = false;
            }

            if (fromTxt.Text.Trim().Length > 0 && passTxt.Text.Trim().Length > 0 && smtpTxt.Text.Trim().Length > 0)
            {
                rememberCheck.Enabled = true;
            }

            else
            {
                rememberCheck.Enabled = false;
                rememberCheck.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HelpForm helper = new HelpForm();
            helper.Show();
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo size = new FileInfo(openDlg.FileName);
                long fSize = size.Length;

                message.Attachments.Add(new Attachment(openDlg.FileName));
                attachLab.Text = "Attachments: " + openDlg.FileName.ToString() + " - " + fSize.ToString() + " Bytes";
            }
        }

        private void clearAttachBtn_Click(object sender, EventArgs e)
        {
            message.Attachments.Clear();
            attachLab.Text = "Attachments: NONE";
        }

        private void clearCredsBtn_Click(object sender, EventArgs e)
        {
            fromTxt.Clear();
            passTxt.Clear();
            smtpTxt.Clear();
        }

        private void clearMessageBtn_Click(object sender, EventArgs e)
        {
            toTxt.Clear();
            subTxt.Clear();
            ccTxt.Clear();
            bccTxt.Clear();
            bodyTxt.Clear();
        }

        private void toLab_Click(object sender, EventArgs e)
        {
            AddressBookForm abf = new AddressBookForm();
            abf.Show();
        }

        private void rememberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberCheck.Checked == true)
            {
                if (!File.Exists("data\\credentials.tm"))
                {
                    File.Create("data\\credentials.tm").Close();
                }

                StreamWriter credStore = new StreamWriter("data\\credentials.tm");

                string[] details = { fromTxt.Text, passTxt.Text, smtpTxt.Text };

                string en1 = EncodeTo64(details[0]);
                string en2 = EncodeTo64(details[1]);
                string en3 = EncodeTo64(details[2]);

                credStore.WriteLineAsync(en1);
                credStore.WriteLineAsync(en2);
                credStore.WriteLineAsync(en3);

                credStore.Close();
            }

            else
            {
                if (File.Exists("data\\credentials.tm"))
                {
                    File.Delete("data\\credentials.tm");
                }
            }
        }

        private void deleteDataBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("data"))
            {           
                Directory.Delete("data", true);
            }
        }
    }
}
