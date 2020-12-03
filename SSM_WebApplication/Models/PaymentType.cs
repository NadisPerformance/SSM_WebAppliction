using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public string ShortDescription { get; set; }
        public DateTime AddDate { get; set; }
        public bool Status { get; set; }
    }
}
