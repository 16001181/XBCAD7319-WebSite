using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Troye_Computer_Systems.Models
{
    public class Communication
    {
        public int EmployeeNumber { get; set; }
        public int cnt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public string Skill { get; set; }
        public string[] TotalPurchasesLastThreeDays { get; set; }

    }
}