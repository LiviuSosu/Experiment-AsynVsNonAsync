using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class Context: DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = EN614080\\SQLEXPRESS;Initial Catalog=Experiments_DB;Integrated Security= True"
                ,x => x.MigrationsAssembly("DAL.Migrations")
                );
            base.OnConfiguring(optionsBuilder);
        }
    }
}
