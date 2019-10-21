using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EditEmployee.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("AppDB")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}