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
                new Fuel { FuelId = 1, FuelName = "Gasoil",FuelPrice=10, ShortDescription = "d1", AddDate = DateTime.Now ,Status= true }
                ) ;
            _ = modelBuilder.Entity<Fuel>().HasData(
                new Fuel { FuelId = 2, FuelName = "Super Sans Plombe", FuelPrice = 20, ShortDescription = "d2", AddDate = DateTime.Now, Status = true }
                );
            modelBuilder.Entity<Fuel>().HasData(
                new Fuel { FuelId = 3, FuelName = "Excellium", FuelPrice = 11, ShortDescription = "d3", AddDate = DateTime.Now, Status = false }
                );

            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 1, PumpName = "P1", PumpDescription = "Pompe 1" ,AddDate=DateTime.Now,Status=true}
                );
            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 2, PumpName = "P2", PumpDescription = "Pompe 2", AddDate = DateTime.Now, Status = true }
                );
            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 3, PumpName = "P3", PumpDescription = "Pompe 3", AddDate = DateTime.Now, Status = true }
                );
            modelBuilder.Entity<Pump>().HasData(
                new Pump { PumpId = 4, PumpName = "P4", PumpDescription = "Pompe 4", AddDate = DateTime.Now, Status = true }
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

            modelBuilder.Entity<FuelPrice>().HasData(
               new FuelPrice { FuelPriceId = 1, Price =10, Comment = "Comment 1", AddDate = DateTime.Now, FuelId=1 }
               );
            modelBuilder.Entity<FuelPrice>().HasData(
             new FuelPrice { FuelPriceId = 2, Price = 20, Comment = "Comment 2", AddDate = DateTime.Now, FuelId = 2 }
             );
            modelBuilder.Entity<FuelPrice>().HasData(
             new FuelPrice { FuelPriceId = 3, Price = 11, Comment = "Comment 3", AddDate = DateTime.Now, FuelId = 3}
             );

            modelBuilder.Entity<Customer>().HasData(
               new Customer { CustomerId = 1, FirstName = "name 1", LastName = " name 1", Company ="company 1",ICE="ice1",Adresse1="adresse 1",Adresse2="adresse 2",City="city 1",Tel1="tel 1",Tel2="tel 2",Email="email 1",ContactName="contact name 1",Status=true,AddDate= DateTime.Now}
               );
            modelBuilder.Entity<Customer>().HasData(
              new Customer { CustomerId = 2, FirstName = "name 2", LastName = " name 2", Company = "company 2", ICE = "ice2", Adresse1 = "adresse 2", Adresse2 = "adresse 2", City = "city 2", Tel1 = "tel 2", Tel2 = "tel 2", Email = "email 2", ContactName = "contact name ", Status = true, AddDate = DateTime.Now }
              );
            modelBuilder.Entity<Customer>().HasData(
              new Customer { CustomerId = 3, FirstName = "name 1", LastName = " name 1", Company = null, ICE = null, Adresse1 = "adresse 1", Adresse2 = "adresse 2", City = "city 1", Tel1 = "tel 1", Tel2 = "tel 2", Email = "email 1", ContactName = "", Status = true, AddDate = DateTime.Now }
              );

            modelBuilder.Entity<Employee>().HasData(
              new Employee { EmployeeId = 1, FirstName = "name 1", LastName = " name 1",  Adresse1 = "adresse 1", Adresse2 = "adresse 2", City = "city 1", Tel1 = "tel 1", Email = "email 1", Status = true, HiringDate = DateTime.Now ,JobId=1 }
              );
            modelBuilder.Entity<Employee>().HasData(
             new Employee { EmployeeId = 2, FirstName = "name 2", LastName = " name 2", Adresse1 = "adresse 2", Adresse2 = "adresse 2", City = "city 1", Tel1 = "tel 1", Email = "email 1", Status = true, HiringDate = DateTime.Now, JobId=2 }
             );
        }
    }
}
