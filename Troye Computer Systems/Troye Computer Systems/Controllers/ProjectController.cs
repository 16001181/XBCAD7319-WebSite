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

namespace Troye_Computer_Systems.Controllers
{
    public class ProjectController : Controller
    {

        DataTable dataTable = new DataTable("Employees");
        //public Colleagues g = new Colleagues();
        // GET: Colleagues
        //[RequireHttps]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            dataTable.Columns.Add(new DataColumn("Employee ID", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Customer ID", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Company", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Task", typeof(string)));
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
            Project obj = response.ResultAs<Project>();
            //this finds out the size of the database with a counter in the table called counter node cnt
            counter = Convert.ToInt32(obj.cnt);
            //change 20 based on the number of people in the table
            while (i < 20)
            {
                i++;
                try
                {
                    //get data from specified table and increment through each of the employees
                    FirebaseResponse resp2 = await client.GetTaskAsync("Project/" + i);
                    Project obj2 = resp2.ResultAs<Project>();
                    DataRow row = dataTable.NewRow();
                    //addeds the employees data to each row with new data and row each time it goes through the while loop
                    //make sure the getters and setters names are the same as in the table or a problem will arise
                    row["Employee ID"] = obj2.EmployeeID;
                    row["Customer ID"] = obj2.CustomerID;
                    row["Company"] = obj2.Company;
                    row["Task"] = obj2.Task;
                    row["Skill"] = obj2.Skills;
                    dataTable.Rows.Add(row);
                }
                catch
                {
                    Debug.Write("Fail, You are going to far and their is no more data! ");
                }

            }
            return View("ProjectView", dataTable);
        }
    }
}