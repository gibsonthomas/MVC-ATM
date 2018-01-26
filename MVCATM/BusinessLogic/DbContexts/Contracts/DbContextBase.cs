using System;
using System.Data.Entity;

namespace BusinessLogic.DbContexts.Contracts
{
    public class DbContextBase : DbContext
    {
        public DbContextBase()
            : base("MvcBank")
        {

        }

        
    }
}
