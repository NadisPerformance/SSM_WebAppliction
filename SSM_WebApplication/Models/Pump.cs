using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class Pump
    {
        [Key]
        public int PumpId { get; set; }
        public string PumpName { get; set; }
        public string PumpDescription { get; set; }
        public List<Distributor> Distributors { get; set;}
}
}
