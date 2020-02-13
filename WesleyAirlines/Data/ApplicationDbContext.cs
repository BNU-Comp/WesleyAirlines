using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WesleyAirlines.Models;

namespace WesleyAirlines.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<WesleyAirlines.Models.Customer> Customer { get; set; }

    }
}
