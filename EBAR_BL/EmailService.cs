using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace EBAR_BL
{
    public class EmailService
    {
        public void SendEmail(string anime, string status)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("EBAR Admin", "do-not-reply@atm.com"));
            message.To.Add(new MailboxAddress("User", "user@example.com"));
            message.Subject = "Welcome to Emoji-based Anime Series Recommendation!";
            message.Body = new TextPart("plain")
            {
                Text = "There is an update in the anime list.\n" +
                       $"Status: Anime '{anime}' has been {status}\n" +
         
                       $"Check it out!"
            };
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var tls = MailKit.Security.SecureSocketOptions.StartTls;
                client.Connect(smtpHost, smtpPort, tls);

                var userName = "ed9e57e165d4ab";
                var password = "7688ef29b1f185";

                client.Authenticate(userName, password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}