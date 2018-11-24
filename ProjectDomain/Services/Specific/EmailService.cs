using ProjectDomain.Interfaces.Services.Specific;
using System;
using System.Net.Mail;
using System.Text;
using System.Web.UI;

namespace ProjectDomain.Services.Specific
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string pDestinatario)
        {
            string nomeRemetente = "nomeRemetente";
            string emailRemetente = "emailRemetente";
            string emailSMTP = "llucasgabriel@hotmail.com";
            string senhaSMTP = "Izachi@1994";
            string destinatario = pDestinatario;
            string smtp = "smtp-mail.outlook.com";
            string assunto = "Qualquer assunto";

            MailMessage email = new MailMessage();

            email.From = new MailAddress(nomeRemetente + "<" + emailSMTP + ">");
            email.To.Add(destinatario);
            //email.CC.Add(string.Empty);
            //email.Bcc.Add(string.Empty);
            email.Priority = MailPriority.Normal;
            email.IsBodyHtml = true;
            email.Subject = assunto;
            email.ReplyTo = new MailAddress(emailSMTP);
            email.Body = "Corpo do e-mail";
            email.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            email.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

            SmtpClient objSmtp = new SmtpClient();

            objSmtp.Credentials = new System.Net.NetworkCredential(emailSMTP, senhaSMTP);
            objSmtp.EnableSsl = true;
            //objSmtp.TargetName = "smtp.gmail.com";
            objSmtp.Host = smtp;
            objSmtp.Port = 587;
            objSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                objSmtp.Send(email);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                email.Dispose();
            }
        }
    }
}
