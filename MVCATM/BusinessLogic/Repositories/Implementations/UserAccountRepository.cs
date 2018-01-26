using BusinessLogic.Models;
using BusinessLogic.Repositories.Contracts;
using System;

namespace BusinessLogic.Repositories.Implementations
{
    public class UserAccountRepository : IUserAccountRepository
    {


        public void CreateUser(UsersAccount userAccount)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int Id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void UpdateUser(UsersAccount userAccount)
        {
            throw new NotImplementedException();
        }
    }
}
