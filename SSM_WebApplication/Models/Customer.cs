using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string ICE { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string City { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public bool Status { get; set; }
        public DateTime AddDate { get; set; }
       
    }
}
