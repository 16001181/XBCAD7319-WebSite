using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Troye_Computer_Systems.Controllers
{
    public class ColleaguesController : Controller
    {
        // GET: Colleagues
        public ActionResult Index()
        {
            return View("CollaguesView");
        }
    }
}