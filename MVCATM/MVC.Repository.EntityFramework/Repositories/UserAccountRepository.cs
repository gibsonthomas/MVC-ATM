using MVC.Models.Models;
using MVC.Repository.Contracts;
using MVC.Repository.EntityFramework.DbContexts.Base;
using System;
using System.Linq;

namespace MVC.Repository.EntityFramework.Repositories
{
    public class UserAccountRepository : IUserAccountRepository
    {
        //readonly UserDbContextBase _dbContext;
        readonly MvcBankEntitiesDbContext _dbContext1;

        public UserAccountRepository(MvcBankEntitiesDbContext dbContext)
        {
            _dbContext1 = dbContext;
            AutoMapper.Initialize();
        }

        public void CreateUser(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_dbContext1 != null)
            {
                _dbContext1.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        public UserAccount GetUser(string username)
        {
            var dbUser = _dbContext1.Users
                .FirstOrDefault(u => u.Username == username);
            var user = AutoMapper.Mapper.Map<User, UserAccount>(dbUser);
            return user;
        }

        public bool Login(string username, string password)
        {
            return _dbContext1.Users
                .Any(u => u.Username == username && u.Password == password);
        }

        public void UpdateUser(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
