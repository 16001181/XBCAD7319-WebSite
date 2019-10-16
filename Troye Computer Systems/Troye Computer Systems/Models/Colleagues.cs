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
        //public string LastName { get; set; }
       // public string Skill { get; set; }
        //public string Email { get; set; }
        
        //public List<string> FirstName = new List<string>(new string[] {"Philip" , "Stewart" });
        //public List<string> LastName = new List<string>(new string[] { "Walker", "Clay" });
        //public List<string> Eamil = new List<string>(new string[] { "Philip@gmail.com", "Stewart@gmail.com" });
        //public List<string> CellNumber = new List<string>(new string[] { "0154119858", "511884844" });
        //public List<string> EmployeeNumeber = new List<string>(new string[] { "1", "2" });
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Salary { get; set; }

        public string Company { get; set; }

        public string Dept { get; set; }


        //public void S()
        //{
        //    FirstName.Add("s");
        //}



    }

}