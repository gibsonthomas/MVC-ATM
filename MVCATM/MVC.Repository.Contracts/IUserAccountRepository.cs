using MVC.Models.Models;
using System;

namespace MVC.Repository.Contracts
{
    public interface IUserAccountRepository : IDisposable
    {
        UserModel GetUser(string username);

        bool Login(string userName, string password);

        void UpdateUser(UserModel userAccount);

        void DeleteUser(int Id);

        void CreateUser(UserModel userAccount);
    }
}
