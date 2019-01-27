using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = EN614080\\SQLEXPRESS;Initial Catalog=Experiments_DB;Integrated Security = True"
                , x => x.MigrationsAssembly("DAL.Migrations")
                );
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int index = 0; index < 1000; index++)
            {
                modelBuilder.Entity<Customer>().HasData(
                   new Customer
                   {
                       CustomerId = Guid.NewGuid(),
                       CustomerName = string.Format("Customer Name {0}",index),
                       EmailAddress = string.Format("customer_{0}_email@smth.com",index),
                       SomeColumn1 = string.Format("some column 1 having index {0}",index),
                       SomeColumn2 = string.Format("some column 2 having index {0}", index),
                       SomeColumn3 = string.Format("some column 3 having index {0}", index),
                       SomeColumn4 = string.Format("some column 4 having index {0}", index),
                       SomeColumn5 = string.Format("some column 5 having index {0}", index),
                       SomeColumn6 = string.Format("some column 6 having index {0}", index),
                       SomeColumn7 = string.Format("some column 7 having index {0}", index),
                       SomeColumn8 = string.Format("some column 8 having index {0}", index),
                       SomeColumn9 = string.Format("some column 9 having index {0}", index),
                       SomeColumn10 = string.Format("some column 10 having index {0}", index),
                       SomeColumn11 = string.Format("some column 11 having index {0}", index),
                       SomeColumn12 = string.Format("some column 12 having index {0}", index),
                       SomeColumn13 = string.Format("some column 13 having index {0}", index),
                       SomeColumn14 = string.Format("some column 14 having index {0}", index),
                       SomeColumn15 = string.Format("some column 15 having index {0}", index),
                       SomeColumn16 = string.Format("some column 16 having index {0}", index),
                       SomeColumn17 = string.Format("some column 17 having index {0}", index),
                       SomeColumn18 = string.Format("some column 18 having index {0}", index),
                       SomeColumn19 = string.Format("some column 19 having index {0}", index),
                       SomeColumn20 = string.Format("some column 20 having index {0}", index)
                   });
            }
        }
    }
}
