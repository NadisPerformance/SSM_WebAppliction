using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class PaymentTypeRepository: IPaymentTypeRepository
    {
        private readonly AppDbContext _appDbContext;
        public PaymentTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PaymentType> GetAllPaymentTypes()
        {
            return _appDbContext.PaymentTypes;
        }

        public PaymentType GetPaymentTypeById(int id)
        {
            return _appDbContext.PaymentTypes.FirstOrDefault(p => p.PaymentTypeId == id);
        }
    }
}
