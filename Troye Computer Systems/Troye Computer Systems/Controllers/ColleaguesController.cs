using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Troye_Computer_Systems.Models;

namespace Troye_Computer_Systems.Controllers
{
    public class ColleaguesController : Controller
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "3JjYU2MerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW",
            BasePath = "https://troye-computer-systems.firebaseio.com/"
        };
        IFirebaseClient client;

        //public Colleagues g = new Colleagues();
        // GET: Colleagues
        //[RequireHttps]
        [HttpGet]
        public ActionResult Index()
        {



            //while (true)
            //{
            //    string url = "https://troye-computer-systems.firebaseio.com/.json";
            //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //    request.ContentType = "Employees/json: charset=utf-8";
            //    HttpWebResponse responsss = request.GetResponse() as HttpWebResponse;
                
            //    using (Stream responseStram = responsss.GetResponseStream())
            //    {
            //        StreamReader reader = new StreamReader(responseStram, Encoding.UTF8);
            //        //Response.Write("<script>alert('Your text');</script>" + reader.ReadToEnd());
            //    }
            //}

            //Colleagues col = new Colleagues
            ////{
            ////    FirstName = "Philip"
            ////};
            ////ViewBag.Message = col;
            ///
            //var model = Troye_Computer_Systems.Models.Colleagues.FirstName;
            //return View("ColleaguesView", model);

            //IFirebaseConfig config = new FirebaseConfig
            //{
            //    AuthSecret = "3JjYU2MerFoAvR5N5yMOaQv3YdH5orw8skiMdXeW",
            //    BasePath = "https://troye-computer-systems.firebaseio.com/"
            //};
            //IFirebaseClient client;

            //client = new FireSharp.FirebaseClient(config);
            //if(client!=null)
            //{
            //    Response.Write("<script>alert('Your text');</script>");
            //}


            //Colleagues g = new Colleagues();
            //List<Colleagues> c = new List<Colleagues>();
            //c.Add(g);


            List<Colleagues> emp = new List<Colleagues>();
            //emp = new List<Colleagues>()
            //{
            //    new Colleagues()
            //    { EmployeeId =1,FirstName="Rakesh",LastName="Kalluri", Email="raki.kalluri@gmail.com", Salary=30000, Company="Summit", Dept="IT" },
            //    new Colleagues()
            //    { EmployeeId =2,FirstName="Naresh",LastName="C", Email="Naresh.C@gmail.com", Salary=50000, Company="IBM", Dept="IT" },
            //    new Colleagues()
            //    { EmployeeId =3,FirstName="Madhu",LastName="K", Email="Madhu.K@gmail.com", Salary=20000, Company="HCl", Dept="IT" },
            //    new Colleagues()
            //    { EmployeeId =4,FirstName="Ali",LastName="MD", Email="Ali.MD@gmail.com", Salary=26700, Company="Tech Mahindra", Dept="BPO" },
            //    new Colleagues()
            //    { EmployeeId =5,FirstName="Chithu",LastName="Raju", Email="Chithu.Raju@gmail.com", Salary=25000, Company="Dell", Dept="BPO" },
            //    new Colleagues()
            //    { EmployeeId =6,FirstName="Nani",LastName="Kumar", Email="Nani.Kumar@gmail.com", Salary=24500, Company="Infosys", Dept="BPO" },

            //};
            emp = new List<Colleagues>()
            {
                new Colleagues()
                {
                    EmployeeId =1,FirstName="Rakesh",LastName="Kalluri", Email="raki.kalluri@gmail.com", Salary=30000, Company="Summit", Dept="IT"

                },
                new Colleagues()
                { EmployeeId =2,FirstName="Naresh",LastName="C", Email="Naresh.C@gmail.com", Salary=50000, Company="IBM", Dept="IT" },
                new Colleagues()
                { EmployeeId =3,FirstName="Madhu",LastName="K", Email="Madhu.K@gmail.com", Salary=20000, Company="HCl", Dept="IT" },
                new Colleagues()
                { EmployeeId =4,FirstName="Ali",LastName="MD", Email="Ali.MD@gmail.com", Salary=26700, Company="Tech Mahindra", Dept="BPO" },
                new Colleagues()
                { EmployeeId =5,FirstName="Chithu",LastName="Raju", Email="Chithu.Raju@gmail.com", Salary=25000, Company="Dell", Dept="BPO" },
                new Colleagues()
                { EmployeeId =6,FirstName="Nani",LastName="Kumar", Email="Nani.Kumar@gmail.com", Salary=24500, Company="Infosys", Dept="BPO" },

            };
            return View("ColleaguesView", emp);

        }

        //[HttpPost]
        //public ActionResult getEmployeeDetails()
        //{
        //    return null;
        //}
    }   
}