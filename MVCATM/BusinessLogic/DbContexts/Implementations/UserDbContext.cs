using BusinessLogic.DbContexts.Contracts;
using BusinessLogic.Models;
using System.Data.Entity;

namespace BusinessLogic.DbContexts.Implementations
{
    public class UserDbContext : UserDbContextBase
    {
        public DbSet<UsersAccount> UserAccount { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersAccount>().ToTable("User");
        }
    }
}
