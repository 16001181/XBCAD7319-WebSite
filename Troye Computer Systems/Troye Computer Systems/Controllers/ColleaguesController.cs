using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Troye_Computer_Systems.Models;

namespace Troye_Computer_Systems.Controllers
{
    public class ColleaguesController : Controller
    {
        //public Colleagues g = new Colleagues();
        // GET: Colleagues
        //[RequireHttps]
        [HttpGet]
        public ActionResult Index()
        {
            //Colleagues col = new Colleagues
            ////{
            ////    FirstName = "Philip"
            ////};
            ////ViewBag.Message = col;
            ///
            //var model = Troye_Computer_Systems.Models.Colleagues.FirstName;
            //return View("ColleaguesView", model);

            Colleagues g = new Colleagues();
            

            return View("ColleaguesView", g);

        }

        //[HttpPost]
        //public ActionResult getEmployeeDetails()
        //{
        //    return null;
        //}

    }
}