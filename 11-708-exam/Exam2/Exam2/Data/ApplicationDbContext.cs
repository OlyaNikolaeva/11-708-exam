using System;
using System.Collections.Generic;
using System.Text;
using Exam2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Exam2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Restarant> Restaurants { get; set; }
        public DbSet<Dishe> Dishes { get; set; }
        public DbSet<Dishe> Orders { get; set; }
        public DbSet<Basket> Basket { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
