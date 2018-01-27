﻿using MVC.Models.Models;
using MVC.Repository.EntityFramework.DbContexts.Base;
using System.Data.Entity;

namespace MVC.Repository.EntityFramework.DbContexts
{
    public class UserDbContext : UserDbContextBase
    {
        public UserDbContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>().ToTable("User");
            modelBuilder.Entity<UserAccount>().HasKey(u => u.UniqueId);
        }
    }
}
