using Microsoft.EntityFrameworkCore;
using System;
using webmvc.Models;

namespace webmvc.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CustomerEntity> CustomerEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>().HasData(
                new CustomerEntity()
                {
                    ID = 1,
                    Code = "C1",
                    NameEN = "Test1",
                    NameTH = "ทดสอบ1",
                    Phone = "9999999999",
                    Email = "test1@gmail.com",
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new CustomerEntity()
                {
                    ID = 2,
                    Code = "C2",
                    NameEN = "Test2",
                    NameTH = "ทดสอบ2",
                    Phone = "9999999999",
                    Email = "test2@gmail.com",
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                }
            );
        }
    }
}