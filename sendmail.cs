using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Farmlink
{
    internal class sendmail
    {
       public bool send(string toEmail, string body , string subject)
        {
            string fromMail = "mubin9516@gmail.com";
            string fromPassword = "sbsx osyi nxjz bepy"; // App Password

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail, "FarmLink");
            message.To.Add(new MailAddress(toEmail));
            message.Subject = subject;
            //message.Subject = "FarmLink Password Reset OTP";

            message.Body = body;

            //// HTML email body
            //message.Body = $@"
            //    <html>
            //    <body style='font-family: Arial; color: #333;'>
            //        <h2>FarmLink - Password Reset</h2>
            //        <p>Your OTP for password reset is:</p>
            //        <h1 style='color: #2E8B57;'>{otp}</h1>
            //        <p>This OTP will expire in 5 minutes.</p>
            //        <br/>
            //        <p>If you did not request this, please ignore this email.</p>
            //        <p style='font-size: 12px;'>- FarmLink Team</p>
            //    </body>
            //    </html>";
            message.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            try
            {
                smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
