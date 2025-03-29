﻿using Microsoft.EntityFrameworkCore;
using nguyenquocduong_2122110443.Model;

namespace nguyenquocduong_2122110443.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

         public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }
    }    
}
