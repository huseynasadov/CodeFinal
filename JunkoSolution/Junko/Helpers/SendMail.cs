using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Junko.Helpers
{
    public class SendMail
    {

        public string SendEmail(AppAdmin appAdmin)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("Huseynia@code.edu.az", "wersdfxcv.1.");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("Huseynia@code.edu.az"),
                    Subject = "Junko Admin Qeydiyyat",
                    Body = "Qeydiyyatdan keçmək üçün daxil olun : <a href='https://localhost:44342/control/users/register?Token=" + appAdmin.ConcurrencyStamp + "'>Profili aktivləşdir</a>"
                };
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(appAdmin.Email));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }

        }

        public string SendSuccess(AppAdmin appAdmin)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("Huseynia@code.edu.az", "wersdfxcv.1.");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("Huseynia@code.edu.az"),
                    Subject = "Junko Admin Qeydiyyat",
                    Body = "Sizin Junko Saytına Adminliyiniz Təsdiqləndi !"
                };
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(appAdmin.Email));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }

        }
    }
}
