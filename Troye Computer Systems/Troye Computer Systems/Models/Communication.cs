using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Troye_Computer_Systems.Models
{
    public class Communication
    {
        public int CommunicationID { get; set; }
        public string CommunicationMessage { get; set; }
        public string Date { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Time { get; set; }

    }
}