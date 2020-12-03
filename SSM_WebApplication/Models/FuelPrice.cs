using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class FuelPrice
    {
        [Key]
        public int FuelPriceId { get; set; }
        public float Price { get; set; }
        [ForeignKey("Fuel")]
        public int FuelId { get; set; }

        public Fuel Fuel { get; set; }
        
        
    }
}
