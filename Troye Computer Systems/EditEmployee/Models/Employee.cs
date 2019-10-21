using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EditEmployee.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeNumber { get; set; }
        //[Required, MinLength(5),Index(IsUnique =true), Column(TypeName = "VARCHAR")]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CellNumber { get; set; }
        [Required]
        public string Skill { get; set; }
        [ScaffoldColumn(false)]
        [Display(Name = "Picture")]
        public string ImageUrl { get; set; }
        
    }
    
}