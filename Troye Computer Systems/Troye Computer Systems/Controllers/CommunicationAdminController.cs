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
//This is where i will pull from firebase and store all messages
namespace Troye_Computer_Systems.Controllers
{
    public class CommunicationAdminController : Controller
    {
        DataTable dataTable = new DataTable("Communication");
        //public Colleagues g = new Colleagues();
        // GET: Colleagues
        //[RequireHttps]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
        
          
            dataTable.Columns.Add(new DataColumn("EmployeeName", typeof(string)));
            dataTable.Columns.Add(new DataColumn("CommunicationMessage", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Date", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Time", typeof(string)));
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
            Communication obj = response.ResultAs<Communication>();
            //this finds out the size of the database with a counter in the table called counter node cnt
            counter = Convert.ToInt32(obj.cnt);
            //change 20 based on the number of people in the table
            while (i < 20)
            {
                i++;
                try
                {
                    //get data from specified table and increment through each of the employees
                    FirebaseResponse resp2 = await client.GetTaskAsync("Communication/" + i);
                    Communication obj2 = resp2.ResultAs<Communication>();
                    DataRow row = dataTable.NewRow();
                    //addeds the employees data to each row with new data and row each time it goes through the while loop
                    //make sure the getters and setters names are the same as in the table or a problem will arise
                    row["CommunicationMessage"] = obj2.CommunicationMessage + "                ";
                    row["Date"] = obj2.Date;
                    row["EmployeeName"] = obj2.EmployeeName;
                    row["Time"] = obj2.Time;
                    dataTable.Rows.Add(row);
                }
                catch
                {
                    Debug.Write("Fail, You are going to far and their is no more data! ");
                }

            }
            return View("CommunicationAdmin", dataTable);
        }
    }
}
