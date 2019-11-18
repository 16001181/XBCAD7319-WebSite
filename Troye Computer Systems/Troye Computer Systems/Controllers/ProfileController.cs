using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Troye_Computer_Systems.Models;

namespace Troye_Computer_Systems.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Edit
        DataTable dataTable = new DataTable("Employees");
        //public Colleagues g = new Colleagues();
        // GET: Colleagues
        //[RequireHttps]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            dataTable.Columns.Add(new DataColumn("Employee Number", typeof(string)));
            dataTable.Columns.Add(new DataColumn("First Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Last Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Email", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Cell Number", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Skill", typeof(string)));
            //creates connection 3to firebase
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "3JjYU2MerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW",
                BasePath = "https://troye-computer-systems.firebaseio.com/"
            };
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            int counter = 0;
            int i = 0;
            FirebaseResponse response = await client.GetTaskAsync("Counter/node");
            Profile obj = response.ResultAs<Profile>();
            //this finds out the size of the database with a counter in the table called counter node cnt
            counter = Convert.ToInt32(obj.cnt);
            //change 20 based on the number of people in the table
            while (i < 20)
            {
                i++;
                try
                {
                    //get data from specified table and increment through each of the employees
                    FirebaseResponse resp2 = await client.GetTaskAsync("Employees/" + i);
                    Profile obj2 = resp2.ResultAs<Profile>();
                    DataRow row = dataTable.NewRow();
                    //added the employees data to each row with new data and row each time it goes through the while loop
                    //make sure the getters and setters names are the same as in the table or a problem will arise
                    row["Employee Number"] = obj2.EmployeeNumber;
                    row["First Name"] = obj2.FirstName;
                    row["Last Name"] = obj2.LastName;
                    row["Email"] = obj2.Email;
                    row["Cell Number"] = obj2.CellNumber;
                    row["Skill"] = obj2.Skill;
                    dataTable.Rows.Add(row);


                    Object EmployeeNumber = row["Employee Number"];
                    Object FirstName = row["First Name"];
                    Object LastName = row["Last Name"];
                    Object Email = row["Email"];
                    Object CellNumber = row["Cell Number"];
                    Object Skill = row["Skill"];
                    dataTable.Rows.GetType();

                    row["Employee Number"] = obj2.EmployeeNumber;
                    row["First Name"] = obj2.FirstName;
                    row["Last Name"] = obj2.LastName;
                    row["Email"] = obj2.Email;
                    row["Cell Number"] = obj2.CellNumber;
                    row["Skill"] = obj2.Skill;
                    dataTable.Rows.Add(row);

                    FirebaseResponse resp = await client.UpdateTaskAsync("Employees/" + i, row);

                    Profile obj1 = resp2.ResultAs<Profile>();
                    DataRow row1 = dataTable.NewRow();
                    //DataRow row1 = dataTable.AcceptChanges(row);


                }
                catch
                {
                    Debug.Write("Fail, You are going to far and their is no more data! ");
                }

            }
            return View("ProfileVIew", dataTable);


        }
        public ActionResult ProductEdit(string id)
        {
            return View("Index");
        }
    }
}