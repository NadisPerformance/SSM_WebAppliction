﻿using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public interface IFuelPriceRepository
    {
        IEnumerable<FuelPrice> GetAllFuelPrices();
        FuelPrice GetFuelPriceById(int Id);
    }
}
