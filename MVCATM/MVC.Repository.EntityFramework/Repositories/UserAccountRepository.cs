using MVC.Models.Models;
using MVC.Repository.Contracts;
using MVC.Repository.EntityFramework.DbContexts.Base;
using System;
using System.Linq;

namespace MVC.Repository.EntityFramework.Repositories
{
    public class UserAccountRepository : IUserAccountRepository
    {
        UserDbContextBase _dbContext;

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
            throw new NotImplementedException();
        }

        public UserAccount GetUser(Guid uniqueId)
        {
            throw new NotImplementedException();
        }

        public bool Login(string userName, string password)
        {
            return _dbContext.UserAccount
                .Any(u => u.Username == userName && u.Password == password);
        }

        public void UpdateUser(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
