using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Core
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = TUFFY; Database = Restaurant; Trusted_Connection = True");
        }

        public virtual DbSet<Cheef> Cheefs { get; set; }
        public virtual DbSet<CookingAparature> CookingAparatures { get; set; }

        public virtual DbSet<Food> Foods { get; set; }
    }
}
