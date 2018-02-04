using MVC.Models.Models;
using MVC.Repository.Contracts;
using MVC.Repository.EntityFramework.DbContexts.Base;
using System;
using System.Linq;

namespace MVC.Repository.EntityFramework.Repositories
{
    public class UserAccountRepository : IUserAccountRepository
    {
        readonly UserDbContextBase _dbContext;

        public UserAccountRepository(UserDbContextBase dbContext)
        {
            _dbContext = dbContext;
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
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }

            GC.SuppressFinalize(this);
        }

        public UserAccount GetUser(string username)
        {
            return _dbContext.UserAccount
                .FirstOrDefault(u => u.Username == username);
        }

        public bool Login(string username, string password)
        {
            return _dbContext.UserAccount
                .Any(u => u.Username == username && u.Password == password);
        }

        public void UpdateUser(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
