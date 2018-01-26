using BusinessLogic.DbContexts.Contracts;
using BusinessLogic.Models;
using System.Data.Entity;

namespace BusinessLogic.DbContexts.Implementations
{
    public class UserDbContext : UserDbContextBase
    {
        public UserDbContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersAccount>().ToTable("User");
            modelBuilder.Entity<UsersAccount>().HasKey(u => u.UniqueId);
        }
    }
}
