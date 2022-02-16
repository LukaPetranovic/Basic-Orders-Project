using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Basic_Orders_Project.Models;

namespace Basic_Orders_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Basic_Orders_Project.Models.Orders> Orders { get; set; }
        public DbSet<Basic_Orders_Project.Models.Customer> Customer { get; set; }
    }
}
