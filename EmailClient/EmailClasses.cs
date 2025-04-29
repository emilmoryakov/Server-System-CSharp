using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;

namespace EmailClient
{

    public class Email
    {
        public string subject;
        public string sender;
        public string body;

        public void SendEmail(string recipient, string subject, string body)
        {
            using (var client = new SmtpClient("your_smtp_host", 587))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("moryakovemil@gmail.com", "bgakudnxfmrvspnm");

                var message = new MailMessage("moryakovemil@gmail.com", recipient, subject, body);

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                }
            }
        }

        public string ReceiveEmails()
        {
            using (var client = new ImapClient())
            {
                List<MailMessage> Emails  = new List<MailMessage>();

                client.Connect("your_imap_host", 993, true);
                client.Authenticate("your_email@example.com", "your_email_password");

                client.Inbox.Open(FolderAccess.ReadOnly);

                var uids = client.Inbox.Search(SearchQuery.NotSeen);

                foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);

                    Emails.MailMessage.Add(message);

                }



                client.Disconnect(true);
            }
        }

    }
}