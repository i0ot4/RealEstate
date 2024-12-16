
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<VirtualTour> VirtualTours { get; set; }

        /*
                public DbSet<FinancialDetail> FinancialDetails { get; set; }
                public DbSet<Investment> Investments { get; set; }
                public DbSet<Rental> Rentals { get; set; }
                public DbSet<Purchase> Purchases { get; set; }*/
    }
}
