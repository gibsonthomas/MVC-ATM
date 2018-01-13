using BusinessLogic.Models;
using System;

namespace BusinessLogic.Repositories.Contracts
{
    public interface IUserAccountRepository
    {
        UsersAccount GetUser(string username);

        UsersAccount GetUser(Guid uniqueId);

        bool Login(string userName, string password);

        void UpdateUser(UsersAccount userAccount);

        void DeleteUser(int Id);

        void CreateUser(UsersAccount userAccount);
    }
}
