using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LearMVC1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }

       public string LastName { get; set; }

        public long? Salary { get; set; }

    }
}