using MVC.Models.Models;
using System.Data.Entity;

namespace MVC.Repository.EntityFramework.DbContexts.Base
{
    public class UserDbContextBase : DbContextBase
    {
        public DbSet<UserModel> UserAccount { get; set; }
    }
}
