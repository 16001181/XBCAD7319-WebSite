using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Troye_Computer_Systems.Model
{
    public class Project
    {

        public string Company { get; set; }
        public string CustomerID { get; set; }
        public string EmployeeID { get; set; }
        public string Skills { get; set; }
        public string Task { get; set; }
    }
}