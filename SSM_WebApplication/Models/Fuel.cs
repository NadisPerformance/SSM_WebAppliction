using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class Fuel
    {
        [Key]
        public int FuelId { get; set; }
        public string FuelName { get; set; }
        public string ShortDescription { get; set; }
        public DateTime AddDate { get; set; }
        public bool Status { get; set; }

    }
}
