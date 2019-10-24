using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Troye_Computer_Systems.Models
{
    public class Projects
    {
        public string Company { get; set; }
        public string CustomerID { get; set; }
        public string EmployeeID { get; set; }
        public string Skills { get; set; }
        public string Task { get; set; }
    }

    public class CompanyName
    {
        public string Company { get; set; }
    }
}