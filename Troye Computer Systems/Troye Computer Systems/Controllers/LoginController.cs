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
    public class LoginController : Controller
    {
        DataTable dataTable = new DataTable("LoginInfo");

        // GET: Login
        [HttpGet]
        

        public async Task<ActionResult> Index()
        {
            //dataTable.Columns.Add(new DataColumn("EmployeeID", typeof(string)));
            //dataTable.Columns.Add(new DataColumn("Password", typeof(string)));
            //dataTable.Columns.Add(new DataColumn("Username", typeof(string)));

            ////creates connection 3to firebase
            //IFirebaseConfig config = new FirebaseConfig
            //{
            //    AuthSecret = "3JjYU2MerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW",
            //    BasePath = "https://troye-computer-systems.firebaseio.com/"
            //};
            //IFirebaseClient client;
            //client = new FireSharp.FirebaseClient(config);
            //int counter = 0;
            //int i = 0;
            //FirebaseResponse response = await client.GetTaskAsync("Counter/node");
            //Colleagues obj = response.ResultAs<Colleagues>();
            ////this finds out the size of the database with a counter in the table called counter node cnt
            //counter = Convert.ToInt32(obj.cnt);
            ////change 20 based on the number of people in the table
            //while (i < 10)
            //{
            //    i++;
            //    try
            //    {
            //        //get data from specified table and increment through each of the employees
            //        FirebaseResponse resp2 = await client.GetTaskAsync("LoginDetails/" + i);
            //        Login obj2 = resp2.ResultAs<Login>();
            //        DataRow row = dataTable.NewRow();
            //        //addeds the employees data to each row with new data and row each time it goes through the while loop
            //        //make sure the getters and setters names are the same as in the table or a problem will arise
            //        row["EmployeeID"] = obj2.EmployeeID;
            //        row["Password"] = obj2.Password;
            //        row["Username"] = obj2.Username;
                    
            //        dataTable.Rows.Add(row);
            //    }
            //    catch
            //    {
            //        Debug.Write("Fail, You are going to far and their is no more data! ");
            //    }

            //}
            return View("LoginView", dataTable);
        }

        

        [HttpPost]
        public async Task<ActionResult> postusingparameters(string Name, string Password)
        {
            Models.Login s = new Models.Login();
            s.Username = Name;
            s.Password = Password;


            String sName = s.Username;
            

            Debug.Write("sdddddddddddddddddddddddddddddddddddddddddddddddddddd" + sName + " " + s.Password );
            //add error checking
            //return Content("<script language='javascript' type='text/javascript'>alert ('Email successfully sent I will be in contact with you as soon as possible! ');</script>");


            dataTable.Columns.Add(new DataColumn("Admin", typeof(string)));
            dataTable.Columns.Add(new DataColumn("EmployeeID", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Password", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Username", typeof(string)));
            

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
            Colleagues obj = response.ResultAs<Colleagues>();
            //this finds out the size of the database with a counter in the table called counter node cnt
            counter = Convert.ToInt32(obj.cnt);
            //change 20 based on the number of people in the table
            while (i < 20)
            {
                i++;
                try
                {
                    //get data from specified table and increment through each of the employees
                    FirebaseResponse resp2 = await client.GetTaskAsync("LoginDetails/" + i);
                    Login obj2 = resp2.ResultAs<Login>();
                    DataRow row = dataTable.NewRow();
                    //addeds the employees data to each row with new data and row each time it goes through the while loop
                    //make sure the getters and setters names are the same as in the table or a problem will arise
                    row["Admin"] = obj2.Admin;
                    row["EmployeeID"] = obj2.EmployeeID;
                    row["Name"] = obj2.Name;
                    row["Password"] = obj2.Password;
                    row["Username"] = obj2.Username;
                    dataTable.Rows.Add(row);
                    Debug.Write("essss ******************" + obj2.Admin);

                    if (obj2.Username== s.Username && obj2.Password == s.Password && obj2.Admin.Equals("yes"))
                    {
                        Debug.Write("Correct                    **************************");
                        return RedirectToAction("Index", "CommunicationAdmin");
                    }
                    else 
                    if (obj2.Username == s.Username && obj2.Password == s.Password)
                    {
                        Debug.Write("correct customer                    ************************");
                        return RedirectToAction("Index", "Communication");
                    }
                    else
                        Debug.Write("Incorrect                     ************************");
                }
                catch
                {
                    Debug.Write("Fail, You are going to far and their is no more data! ");
                }

            }





            return RedirectToAction("Index", "Login");
        }

    }
}