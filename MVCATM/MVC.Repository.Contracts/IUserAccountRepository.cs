using MVC.Models.Models;
using System;

namespace MVC.Repository.Contracts
{
    public interface IUserAccountRepository : IDisposable
    {
        UserAccount GetUser(string username);

        UserAccount GetUser(Guid uniqueId);

        bool Login(string userName, string password);

        void UpdateUser(UserAccount userAccount);

        void DeleteUser(int Id);

        void CreateUser(UserAccount userAccount);
    }
}
