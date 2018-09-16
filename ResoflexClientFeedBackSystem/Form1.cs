using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientFeedBackSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fromAddress = new MailAddress("techninjas3.0v@gmail.com");
                var fromPassword = "Techninjas@SLIIT";
                var toAddress = new MailAddress("geeth.gsm@gmail.com");

                string subject = "Bug Reporter";
                string body = msgTxtBox.Text;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })

                    smtp.Send(message);

                notifyIconMailSuccessful.Icon = SystemIcons.Application;
                notifyIconMailSuccessful.BalloonTipText = "Email sent successfully!";
                notifyIconMailSuccessful.ShowBalloonTip(200);

                msgTxtBox.Text = "";

                string result = sendSms("message");

                if (result != null)
                    msgTxtBox.Text = result;

                notifyIconMailSuccessful.Icon = SystemIcons.Application;
                notifyIconMailSuccessful.BalloonTipText = "SMS sent successfully!";
                notifyIconMailSuccessful.ShowBalloonTip(200);

                if (checkBoxTV.Checked)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();

                    process.StartInfo.FileName = "C:\\Program Files (x86)\\TeamViewer\\TeamViewer.exe";
                    process.EnableRaisingEvents = true;

                    process.Start();

                    process.WaitForExit();

                    msgTxtBox.Text = "TeamViewer Exited";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Mail sender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        public string sendSms(string msg)
        {
            //String message = HttpUtility.UrlEncode("This is your message");
            String message = "This is your message";
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.txtlocal.com/send/", new NameValueCollection()
                {
                {"apikey" , "vuHeQkjT1nE-kGtSpqkwMKOhPRGl2AGXtCDYvi4JGP"},
                {"numbers" , "94777188617"},
                {"message" , message},
                {"sender" , "Jims Autos"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (PingHost("www.microsoft.com"))
            {
                checkBoxTV.Visible = true;
                label2.Text = "RFS is Online!";
            }
            else
            {
                checkBoxTV.Visible = false;
                label2.Text = "RFS is Offline!";
            }
        }
    }
}
