using BusinessLogic.Models;
using System.Data.Entity;

namespace BusinessLogic.DbContexts
{
    public class UserDbContext : DbContext
    {

        public DbSet<UsersAccount> UserAccount { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersAccount>().ToTable("");
        }
    }
}
