using System;
using System.Web.Mvc;
using Attractions.Models;
using Attractions.Services;

namespace Attractions.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailService _mail;

        public HomeController(IMailService mail)
        {
            _mail = mail;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            var msg = String.Format("Message from: {1}{0} Email Address: {2}{0} Comment {3}{0}", 
                Environment.NewLine, model.Name, model.Email, model.Message);

            if (_mail.SendMail("noreply@domain.com", "jrpnetdev@jrpnetdev.com", "Website Contact Form", msg))
            {
                ViewBag.MailSent = true;
            }

            return View();
        } 

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Favourites()
        {
            // ToDo: Only show when Logged in, Hide Login Link 
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}