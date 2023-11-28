using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RestaurantContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=eatdbsomeebrc.mssql.somee.com;Database=eatdbsomeebrc;User Id=burcutas_SQLLogin_1; password=ntd8wehwln;TrustServerCertificate=true");
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchImage> BranchImages { get; set; }
        public DbSet<BranchEmployee> BranchEmployees { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<MealCategory> MealCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
