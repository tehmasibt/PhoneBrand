using Microsoft.EntityFrameworkCore;
using ORM.Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Phone.DAL
{
    internal class DataContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HPCK2O7;Database=Telephone;Trusted_Connection=true;TrustServerCertificate=true");
        }
    }
}
