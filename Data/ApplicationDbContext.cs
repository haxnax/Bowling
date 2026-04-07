using Bowling.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BowlingHall> BowlingHalls { get; set; }
        public DbSet<BowlingLane> BowlingLanes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext()
        {
            // en tom konstruktor behövs för att skapa migrations
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}