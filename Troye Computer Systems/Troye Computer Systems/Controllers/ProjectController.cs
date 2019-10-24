using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
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
        DataTable dataTable = new DataTable("Projects");
        DataTable dataTableName = new DataTable("Projects");
        int z = 0;
        Object companyName;
        // GET: Project

        private SelectList CompanyName(string[] selectedValues)
        {
          
            while (dataTable.Rows.Count > 10)
            {


                companyName = dataTable.Rows[z]["Company"];
                z++;
            }


            return new SelectList(selectedValues);
        }

        [HttpPost]
        //public ActionResult Indexx (FormCollection form)
        //{
        //    ViewBag.YouSelected = form["Company"];
        //    string selectedValues = form["Company"];
        //    ViewBag.CompanyName(selectedValues);
        //    return View();
        //}
        public async Task<ActionResult> Index(FormCollection form)
        {
            //the rows of the database
            dataTable.Columns.Add(new DataColumn("Employee Number", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Customer ID", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Company", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Task", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Sills", typeof(string)));
            //creates connection 3to firebase

            //the selection of the items of the company name
            ViewBag.YouSelected = form["Company"];
            string selectedValues = form["Company"];
            ViewBag.CompanyName(selectedValues);

            //creates connectionfirebase
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "3JjYU2MerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW",
                BasePath = "https://troye-computer-systems.firebaseio.com/"
            };
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            int counter = 0;
            int i = 0;
            FirebaseResponse response = await client.GetAsync("Counter/node");
            Projects obj = response.ResultAs<Projects>();
            //this finds out the size of the database with a counter in the table called counter node cnt
            // counter = Convert.ToInt32(obj.cnt);
            while (i < 10)
            {
                i++;
                try
                {
                    //get data from specified table and increment through each of the employees
                    FirebaseResponse resp2 = await client.GetAsync("Project/" + i);
                    Projects obj2 = resp2.ResultAs<Projects>();
                    DataRow row = dataTable.NewRow();
                    //addeds the projects data to each row with new data and row each time it goes through the while loop
                    //have get and set
                    row["Employee ID"] = obj2.EmployeeID;
                    row["Customer ID"] = obj2.CustomerID;
                    row["Company"] = obj2.Company;
                    row["Task"] = obj2.Task;
                    row["Sills"] = obj2.Skills;
                    dataTable.Rows.Add(row);

                    //var company = new List<Projects>()
                    //{
                    //    new Projects() obj2.Company; 
                
                    //};

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














                  