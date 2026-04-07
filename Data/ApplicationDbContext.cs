using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Data
{
    public class ApplicationDbContext : DbContext
    {


        public DbSet<Booking> deleteme { get; set; }


        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=DBBowling;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
    }

}
