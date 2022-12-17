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
using System.Net.Http;

namespace SendEmail
{
    public partial class Form1 : Form
    {

        // variables for login information, the SMTP client needed to send emails to any email directory, and the content itself

        NetworkCredential loginInfo;

        SmtpClient smtpClient;

        MailMessage content;


        //the form itself
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // this will send all the content embedded within the textbox 
        private void sendButtonOnClick(object sender, EventArgs e)
        {
            loginInfo = new NetworkCredential(userTextBox.Text, passWordTextBox.Text);

            smtpClient = new SmtpClient(portTextBox.Text);

            smtpClient.Port = Convert.ToInt32(portTextBox.Text);

            smtpClient.EnableSsl = sslCheckBox.Checked;

            smtpClient.Credentials = loginInfo;

            content = new MailMessage { From = new MailAddress(userTextBox.Text, smtpTextBox.Text.Replace("smtp.", "@"), "", Encoding.UTF8)};

            content.To.Add(new MailAddress(recipientTextBox.Text));

            if (!string.IsNullOrEmpty(carbonCopyTextBox.Text)) {
                content.To.Add(new MailAddress(carbonCopyTextBox.Text));
            }

            content.Subject = subjectTextBox.Text;
            content.Body = messageContent.Text;
            content.BodyEncoding = Encoding.UTF8;
            content.Subject = subjectTextBox.Text;


        }
    }
}
