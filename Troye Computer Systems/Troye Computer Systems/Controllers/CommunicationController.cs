using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//This is where i will pull from firebase and store all messages
namespace Troye_Computer_Systems.Controllers
{
    public class CommunicationController : Controller
    {
        // GET: Communication
        public ActionResult Index()
        {

            return View("CommunicationView");

        }
        [HttpPost]
        public ActionResult postusingparameters(string name, string emailAddress, string subject, string body)
        {
            Models.Communication s = new Models.Communication();
            s.Name = name;
            s.EmailAddress = emailAddress;
            s.Subject = subject;
            s.GetMessage = body;
            //add error checking
            //return Content("<script language='javascript' type='text/javascript'>alert ('Email successfully sent I will be in contact with you as soon as possible! ');</script>");

            return RedirectToAction("Index", "Home");
        }
    }
}
