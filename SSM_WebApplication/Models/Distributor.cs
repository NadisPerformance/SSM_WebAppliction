using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class Distributor
    {
        [Key]
        public int DistributorId { get; set; }
        public string DistributorName { get; set; }
        public string DistributorDescription { get; set; }
        public DateTime AddDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Fuel")]
        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }
        [ForeignKey("Pump")]
        public int PumpId { get; set; }
        public Pump Pump { get; set; }
    }
}
