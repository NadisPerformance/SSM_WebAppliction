using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Pump> Pumps { get; set; } 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<FuelPrice> FuelPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Fuel>().HasData(
                new Fuel { FuelId = 1, FuelName = "Gasoil", ShortDescription = "d1", AddDate = Convert.ToDateTime("2020-12-01") ,Status= true }
                ) ;
            _ = modelBuilder.Entity<Fuel>().HasData(
                new Fuel { FuelId = 2, FuelName = "Super Sans Plombe", ShortDescription = "d2", AddDate = Convert.ToDateTime("2020-11-01"), Status = true }
                );
            modelBuilder.Entity<Fuel>().HasData(
                new Fuel { FuelId = 3, FuelName = "Excellium", ShortDescription = "d3", AddDate = Convert.ToDateTime("2020-12-02"), Status = false }
                );

            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 1, PumpName = "P1", PumpDescription = "Pompe 1" }
                );
            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 2, PumpName = "P2", PumpDescription = "Pompe 2" }
                );
            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 3, PumpName = "P3", PumpDescription = "Pompe 3" }
                );
            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 4, PumpName = "P4", PumpDescription = "Pompe 4" }
                );

            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 1, DistributorName = "d1", DistributorDescription = "Pistolet 1",AddDate=Convert.ToDateTime("2020-11-15"),Status=true, PumpId = 1, FuelId = 2 }
                ) ;
            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 2, DistributorName = "d2", DistributorDescription = "Pistolet 2",AddDate=Convert.ToDateTime("2020-10-20"),Status=false,PumpId = 1, FuelId = 2 }
                );
            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 3, DistributorName = "d3", DistributorDescription = "Pistolet 3", AddDate = Convert.ToDateTime("2020-10-20"), Status = false, PumpId = 2, FuelId = 1 }
                );
            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 4, DistributorName = "d4", DistributorDescription = "Pistolet 4", AddDate = Convert.ToDateTime("2020-10-20"), Status = false, PumpId = 2, FuelId = 3 }
                );
            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 5, DistributorName = "d5", DistributorDescription = "Pistolet 5", AddDate = Convert.ToDateTime("2020-10-20"), Status = false, PumpId = 3, FuelId = 1 }
                );
            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 6, DistributorName = "d6", DistributorDescription = "Pistolet 6", AddDate = Convert.ToDateTime("2020-10-20"), Status = false, PumpId = 3, FuelId = 3 }
                );
            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 7, DistributorName = "d7", DistributorDescription = "Pistolet 7", AddDate = Convert.ToDateTime("2020-10-20"), Status = false, PumpId = 4, FuelId = 2 }
                );
            modelBuilder.Entity<Distributor>().HasData(
                new Distributor { DistributorId = 8, DistributorName = "d8", DistributorDescription = "Pistolet 8", AddDate = Convert.ToDateTime("2020-10-20"), Status = false, PumpId = 4, FuelId = 1 }
                );

            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle { JobId = 1, JobName = "J1", ShortDescription = "Job 1" ,AddDate=Convert.ToDateTime("2020-12-12"),Status= false }
                );
            modelBuilder.Entity<JobTitle>().HasData(
               new JobTitle { JobId = 2, JobName = "J2", ShortDescription = "Job 2", AddDate = Convert.ToDateTime("2020 - 11 - 11"), Status = false }
               );
            modelBuilder.Entity<JobTitle>().HasData(
               new JobTitle { JobId = 3, JobName = "J3", ShortDescription = "Job 3", AddDate = Convert.ToDateTime("2020 - 02 - 10"), Status = false }
               );

            modelBuilder.Entity<PaymentType>().HasData(
               new PaymentType { PaymentTypeId = 1, PaymentTypeName = "p1", ShortDescription = "payment 1", AddDate = Convert.ToDateTime("2020 - 10 - 12"), Status = false }
               );
        }
    }
}
