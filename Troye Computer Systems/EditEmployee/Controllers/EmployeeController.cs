using EditEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public ActionResult EmployeeProfile()
        {
            int EmployeeNumber = Convert.ToInt32(Session["EmployeeId"]);
            if (EmployeeNumber == 0)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(db.Employees.Find(EmployeeNumber));

        }
            //[HttpPost]
            /*public ActionResult UpdatePicture(PictureVM obj)
                {
                    int EmployeeNumber = Convert.ToInt32(Session["EmployeeId"]);
                    if (EmployeeNumber == 0)
                        {
                            
                        }
                }*/

        
    }
}