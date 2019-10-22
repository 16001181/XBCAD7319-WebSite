using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Troye_Computer_Systems.Model;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Diagnostics;
using System.Data;

namespace Troye_Computer_Systems.Controllers
{
    public class ProjetControllers : Controller
    {

        
        //DataTable dataTable = new DataTable("Employees");
       
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //dataTable.Columns.Add(new DataColumn("Employee Number", typeof(string)));
            //dataTable.Columns.Add(new DataColumn("First Name", typeof(string)));
            //dataTable.Columns.Add(new DataColumn("Last Name", typeof(string)));
            //dataTable.Columns.Add(new DataColumn("Email", typeof(string)));
            //dataTable.Columns.Add(new DataColumn("Cell Number", typeof(string)));
            //dataTable.Columns.Add(new DataColumn("Skill", typeof(string)));

            //creates connection to firebase
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
            while (i < 10)
            {
                i++;
                try
                {
                    //get data from specified table and increment through each of the employees
                    FirebaseResponse resp2 = await client.GetTaskAsync("Employees/" + i);
                    Project obj2 = resp2.ResultAs<Project>();
                   // DataRow row = dataTable.NewRow();
                    //addeds the employees data to each row with new data and row each time it goes through the while loop
                    //make sure the getters and setters names are the same as in the table or a problem will arise
                    listv = obj2.Company;
                    row["First Name"] = obj2.Task;
                    row["Last Name"] = obj2.CustomerID;
                    row["Email"] = obj2.EmployeeID;
                    row["Cell Number"] = obj2.Skills;
                    
                    //dataTable.Rows.Add(row);
                }
                catch
                {
                    Debug.Write("Fail, You are going to far and their is no more data! ");
                }

            }
            return View("ColleaguesView", dataTable);
        }
    }
}