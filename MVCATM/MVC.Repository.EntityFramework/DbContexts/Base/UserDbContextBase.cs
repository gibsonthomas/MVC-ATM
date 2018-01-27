﻿using BusinessLogic.Models;
using System.Data.Entity;

namespace BusinessLogic.DbContexts.Contracts
{
    public class UserDbContextBase : DbContextBase
    {
        public DbSet<UserAccount> UserAccount { get; set; }
    }
}