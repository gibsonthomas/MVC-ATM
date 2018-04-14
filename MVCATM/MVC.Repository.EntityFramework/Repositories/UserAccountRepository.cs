using MVC.Models.Models;
using MVC.Repository.Contracts;
using System;
using System.Linq;

namespace MVC.Repository.EntityFramework.Repositories
{
    public class UserAccountRepository : IUserAccountRepository
    {
        readonly MvcBankEntities1 _dbContext;

        public UserAccountRepository(MvcBankEntities1 dbContext)
        {
            _dbContext = dbContext;
            AutoMapper.Initialize();
        }

        public void CreateUser(UserModel userAccount)
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

        public UserModel GetUser(string username)
        {
            var dbUser = _dbContext.Users
                .FirstOrDefault(u => u.Username == username);
            var user = AutoMapper.Mapper.Map<User, UserModel>(dbUser);
            return user;
        }

        public bool Login(string username, string password)
        {
            return _dbContext.Users
                .Any(u => u.Username == username && u.Password == password);
        }

        public void UpdateUser(UserModel userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
