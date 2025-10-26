using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBAR_BL
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SendEmail(string anime, string status)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(
                _configuration["EmailSettings:FromName"],
                _configuration["EmailSettings:FromEmail"]
            ));
            message.To.Add(new MailboxAddress("User", "user@example.com"));
            message.Subject = "Welcome to Emoji-based Anime Series Recommendation!";
            message.Body = new TextPart("plain")
            {
                Text = "There is an update in the anime list.\n" +
                       $"Status: Anime '{anime}' has been {status}\n" +
         
                       $"Check it out!"
            };
            using (var client = new SmtpClient())
            {
                client.Connect(
                     _configuration["EmailSettings:SmtpHost"],
                     int.Parse(_configuration["EmailSettings:SmtpPort"]),
                     SecureSocketOptions.StartTls
                 );

                client.Authenticate(
                    _configuration["EmailSettings:Username"],
                    _configuration["EmailSettings:Password"]
                );

                //var userName = "ed9e57e165d4ab";
                //var password = "7688ef29b1f185";

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}