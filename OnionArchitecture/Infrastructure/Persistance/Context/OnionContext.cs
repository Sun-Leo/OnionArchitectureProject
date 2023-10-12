using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context
{
    public class OnionContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;initial catalog=OnionDb;integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OurDishes> OurDishes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BreakfastMenu> BreakfastMenus { get; set; }
        public DbSet<LunchMenu> LunchMenus { get; set; }
        public DbSet<DinnerMenu> DinnerMenus { get; set; }

    }
}
