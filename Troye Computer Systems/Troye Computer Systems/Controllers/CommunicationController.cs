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
    public class CommunicationController : Controller
    {
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
            Communication obj = response.ResultAs<Communication>();
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
                    Communication obj2 = resp2.ResultAs<Communication>();
                    DataRow row = dataTable.NewRow();
                    //addeds the employees data to each row with new data and row each time it goes through the while loop
                    //make sure the getters and setters names are the same as in the table or a problem will arise
                    row["Employee Number"] = obj2.EmployeeNumber;
                    row["First Name"] = obj2.FirstName;
                    row["Last Name"] = obj2.LastName;
                    row["Email"] = obj2.Email;
                    row["Cell Number"] = obj2.CellNumber;
                    row["Skill"] = obj2.Skill;
                    dataTable.Rows.Add(row);
                }
                catch
                {
                    Debug.Write("Fail, You are going to far and their is no more data! ");
                }

            }
            return View("CommunicationView", dataTable);
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.Mvc;
//using Troye_Computer_Systems.Models;
//using FireSharp.Config;
//using FireSharp.Interfaces;
//using FireSharp.Response;
//using System.Diagnostics;
//using System.Data;

//namespace Troye_Computer_Systems.Controllers
//{
//    public class ColleaguesController : Controller
//    {
//        //variable declarations
//        DataTable dataTable = new DataTable("Employees");
//        //public Colleagues g = new Colleagues();
//        // GET: Colleagues
//        //[RequireHttps]
//        [HttpGet]
//        public async Task<ActionResult> Index()
//        {
//            dataTable.Columns.Add(new DataColumn("Employee Number", typeof(string)));
//            dataTable.Columns.Add(new DataColumn("First Name", typeof(string)));
//            dataTable.Columns.Add(new DataColumn("Last Name", typeof(string)));
//            dataTable.Columns.Add(new DataColumn("Email", typeof(string)));
//            dataTable.Columns.Add(new DataColumn("Cell Number", typeof(string)));
//            dataTable.Columns.Add(new DataColumn("Skill", typeof(string)));
//            //creates connection 3to firebase
//            IFirebaseConfig config = new FirebaseConfig
//            {
//                AuthSecret = "3JjYU2MerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW",
//                BasePath = "https://troye-computer-systems.firebaseio.com/"
//            };
//            IFirebaseClient client;
//            client = new FireSharp.FirebaseClient(config);
//            int counter = 0;
//            int i = 0;
//            FirebaseResponse response = await client.GetTaskAsync("Counter/node");
//            Colleagues obj = response.ResultAs<Colleagues>();
//            //this finds out the size of the database with a counter in the table called counter node cnt
//            counter = Convert.ToInt32(obj.cnt);
//            //change 20 based on the number of people in the table
//            while (i < 10)
//            {
//                i++;
//                try
//                {
//                    //get data from specified table and increment through each of the employees
//                    FirebaseResponse resp2 = await client.GetTaskAsync("Employees/" + i);
//                    Colleagues obj2 = resp2.ResultAs<Colleagues>();
//                    DataRow row = dataTable.NewRow();
//                    //addeds the employees data to each row with new data and row each time it goes through the while loop
//                    //make sure the getters and setters names are the same as in the table or a problem will arise
//                    row["Employee Number"] = obj2.EmployeeNumber;
//                    row["First Name"] = obj2.FirstName;
//                    row["Last Name"] = obj2.LastName;
//                    row["Email"] = obj2.Email;
//                    row["Cell Number"] = obj2.CellNumber;
//                    row["Skill"] = obj2.Skill;
//                    dataTable.Rows.Add(row);
//                }
//                catch
//                {
//                    Debug.Write("Fail, You are going to far and their is no more data! ");
//                }

//            }
//            return View("ColleaguesView", dataTable);
//        }
//    }
//}