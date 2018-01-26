using BusinessLogic.DbContexts.Contracts;
using BusinessLogic.DbContexts.Implementations;
using BusinessLogic.Models;
using BusinessLogic.Repositories.Contracts;
using System;
using System.Linq;

namespace BusinessLogic.Repositories.Implementations
{
    public class UserAccountRepository : IUserAccountRepository
    {
        UserDbContextBase _dbContext;

        public UserAccountRepository()
            : this(null)
        {

        }

        public UserAccountRepository(UserDbContextBase dbContext)
        {
            _dbContext = dbContext ?? new UserDbContext();
        }

        public void CreateUser(UsersAccount userAccount)
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

        public UsersAccount GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public UsersAccount GetUser(Guid uniqueId)
        {
            throw new NotImplementedException();
        }

        public bool Login(string userName, string password)
        {
            return _dbContext.UserAccount
                .Any(u => u.Username == userName && u.Password == password);
        }

        public void UpdateUser(UsersAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
