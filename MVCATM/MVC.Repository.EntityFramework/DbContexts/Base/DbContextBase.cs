using System;
using System.Data.Entity;

namespace MVC.Repository.EntityFramework.DbContexts.Base
{
    public class DbContextBase : DbContext
    {
        public DbContextBase()
            : base("MvcBank")
        {

        }


    }
}
