using System;
using System.Net.Mail;
using System.Text;
using System.Web.Mvc;
using GoulouWebApp.Models;

namespace GoulouWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(new AboutViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult About(AboutViewModel model)
        {
            SmtpClient client = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new System.Net.NetworkCredential("elodie.marie.trash@gmail.com", "@0emt@!!")
            };

            MailMessage mm = new MailMessage(new MailAddress("DoNotReply@goulougoulou.com", "DoNotReply"), new MailAddress("elodie.marie.91@gmail.com", "Cedric Nivoliez"))
            {
                Body = "Ouiiiiiiiiiiiiiiiiiiiiiiiiiiii",
                Subject = "GoulouTest",
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            };

            try
            {
                client.Send(mm);
            }
            catch (Exception exception)
            {    
                Console.WriteLine(exception);
            }
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}