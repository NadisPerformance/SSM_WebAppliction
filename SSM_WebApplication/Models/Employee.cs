using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string City { get; set; }
        public string Tel1 { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public DateTime HiringDate { get; set; }
        [ForeignKey("JobTitle")]
        public int JobId { get; set; }
        public JobTitle JobTitle { get; set; }

    }
}
