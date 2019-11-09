﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Troye_Computer_Systems.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Diagnostics;
using System.Data;
using Troye_Computer_Systems.Models.Identity;
using Microsoft.AspNet.Identity;
using Troye_Computer_Systems.Models;

namespace Troye_Computer_Systems.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<profile> profileList = db.profiles.ToList<profile>();
                return Json(new { data = profileList, JsonRequestBehavior.AllowGet });
            }
        }

        [HttpGet]
        public ActionResult AddorEdit(int id = 0)
        {
            return View(new profile());
        }

        [HttpPost]
        public ActionResult AddorEdit()
        {
            return View();
        }
        ////private readonly ApplicationDbContext _context;
        ////private UserManager<ApplicationUser> _userManager;

        ////public AccountController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        ////{
        ////    _context = context;
        ////    _userManager = userManager;
        ////}
        //// GET: Account
        //[HttpGet]
        //public async Task<ActionResult> Index()
        //{
        //    DataTable dataTable = new DataTable("ApplicationUsers");
        //    dataTable.Columns.Add(new DataColumn("Employee Number", typeof(string)));
        //    dataTable.Columns.Add(new DataColumn("First Name", typeof(string)));
        //    dataTable.Columns.Add(new DataColumn("Last Name", typeof(string)));
        //    dataTable.Columns.Add(new DataColumn("Email", typeof(string)));
        //    dataTable.Columns.Add(new DataColumn("Cell Number", typeof(string)));
        //    dataTable.Columns.Add(new DataColumn("Skill", typeof(string)));
        //    dataTable.Columns.Add(new DataColumn("ImageUrl", typeof(string)));
        //    //creates connection 3to firebase
        //    IFirebaseConfig config = new FirebaseConfig
        //    {
        //        AuthSecret = "3JjYU2MerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW",
        //        BasePath = "https://troye-computer-systems.firebaseio.com/"
        //    };
        //    IFirebaseClient client;
        //    client = new FireSharp.FirebaseClient(config);
        //    int counter = 0;
        //    int i = 0;
        //    FirebaseResponse response = await client.GetTaskAsync("Counter/node");
        //    ApplicationUser obj = response.ResultAs<ApplicationUser>();
        //    //this finds out the size of the database with a counter in the table called counter node cnt
        //    counter = Convert.ToInt32(obj.cnt);
        //    //change 20 based on the number of people in the table
        //    while (i < 10)
        //    {
        //        i++;
        //        try
        //        {
        //            //get data from specified table and increment through each of the employees
        //            FirebaseResponse resp2 = await client.GetTaskAsync("Employees/" + i);
        //            ApplicationUser obj2 = resp2.ResultAs<ApplicationUser>();
        //            DataRow row = dataTable.NewRow();
        //            //addeds the employees data to each row with new data and row each time it goes through the while loop
        //            //make sure the getters and setters names are the same as in the table or a problem will arise
        //            row["Employee Number"] = obj2.EmployeeNumber;
        //            row["First Name"] = obj2.FirstName;
        //            row["Last Name"] = obj2.LastName;
        //            row["Email"] = obj2.Email;
        //            row["Cell Number"] = obj2.CellNumber;
        //            row["Skill"] = obj2.Skill;
        //            row["ImageUrl"] = obj2.ImageUrl;
        //            dataTable.Rows.Add(row);
        //        }
        //        catch
        //        {
        //            Debug.Write("Fail, You are going to far and their is no more data! ");
        //        }

        //}
        //return View("Login", dataTable);

    }
}