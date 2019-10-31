using Castle.MicroKernel.SubSystems.Conversion;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Troye_Computer_Systems.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int EmployeeNumber { get; set; }
        //[Required, MinLength(5),Index(IsUnique =true), Column(TypeName = "VARCHAR")]
        [Required, MinLength(5), Index(IsUnique = true), Column(TypeName = "VARCHAR")]
        public string FirstName { get; set; }
        public int cnt { get; set; }
        [Required, MinLength(5), Index(IsUnique = true), Column(TypeName = "VARCHAR")]
        public string LastName { get; set; }
        [EmailAddress, Index(IsUnique = true), Column(TypeName = "VARCHAR"), Required]
        public string Email { get; set; }
        [Required]
        public string CellNumber { get; set; }
        [Required]
        public string Skill { get; set; }
        [ScaffoldColumn(false)]
        [Display(Name = "Picture")]
        public string ImageUrl
        {
            get; set;
        }
    }
}