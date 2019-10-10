using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace Troye_Computer_Systems.Models
{


    public class Colleagues
    {
        //public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Skill { get; set; }
        //public string Email { get; set; }
        public  List<string> Eamil = new List<string>(new string[] { "@Philip", "@Stewart" });
        public List<string> FirstName = new List<string>(new string[] {"Philip" , "Stewart" });

    

        //public void S()
        //{
        //    FirstName.Add("s");
        //}



    }
   
}