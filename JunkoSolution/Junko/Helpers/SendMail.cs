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
                var credentials = new NetworkCredential("junkoelectronics@gmail.com", "cdexswzaq.1.");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("junkoelectronics@gmail.com"),
                    Subject = "Junko Admin Qeydiyyat",
                    Body = "Qeydiyyatdan keçmək üçün daxil olun : <a href='https://junkoelectronics.azurewebsites.net/control/users/register?Token=" + appAdmin.ConcurrencyStamp + "'>Profili aktivləşdir</a>"
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
        public string ForgotPassword(AppAdmin appAdmin)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("junkoelectronics@gmail.com", "cdexswzaq.1.");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("junkoelectronics@gmail.com"),
                    Subject = "Junko Şifrə Dəyişimi",
                    Body = "Parolu dəyişdirmək üçün : <a href='https://junkoelectronics.azurewebsites.net/control/users/EditPassword?Token=" + appAdmin.ConcurrencyStamp + "'>Daxil Ol</a>"
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
                var credentials = new NetworkCredential("junkoelectronics@gmail.com", "cdexswzaq.1.");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("junkoelectronics@gmail.com"),
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
