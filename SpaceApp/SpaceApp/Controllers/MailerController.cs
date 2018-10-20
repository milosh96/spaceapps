using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SpaceApp.Controllers
{
    public class MailerController : Controller
    {
        // GET: Mailer
        public ActionResult Index()
        {
            Mail.Send();
            return View();
        }
    }
    public static class Mail
    {
        private static string from = "spacelaunchpublic@gmail.com";
        private static string password = "spacelaunch123";
        public static void Send()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(from,password);
            mail.Subject = "TEST";
            mail.IsBodyHtml = true;
            mail.Body = "ovde neki text";
            mail.From = new MailAddress(from);
            mail.To.Add("tetrakis13@gmail.com");
            SmtpServer.EnableSsl = true;

  
            SmtpServer.Send(mail);
        }
    }
}
