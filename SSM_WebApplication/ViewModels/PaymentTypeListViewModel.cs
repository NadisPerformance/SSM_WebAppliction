using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.ViewModels
{
    public class PaymentTypeListViewModel
    {
        public IEnumerable<PaymentType> PaymentTypes { get; set; }
    }
}
