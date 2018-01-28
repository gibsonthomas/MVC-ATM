using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVC.Models.Models;
using MVC.Repository.EntityFramework.DbContexts.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MVC.Repository.EntityFramework.Test
{
    [TestClass]
    public class UserAccountRepositoryTest
    {
        readonly Mock<UserDbContextBase> _mockedUserDbContext = new Mock<UserDbContextBase>();

        [TestInitialize]
        void Initialize()
        {

        }

        public void Login_ValidCredentials_ValidatesSuccessfullyTest()
        {
            var accounts = new List<UserAccount>
            {
                new UserAccount{
                AccountType = Models.Enums.AccountType.PowerUser,
                MailId = "gibson.thomas@ust-global.com",
                Password = "chanakya",
                UniqueId = Guid.NewGuid(),
                Username = "gibsonthomas"
                }
            }.AsQueryable();


            var mockedUserAccountDbSet = new Mock<DbSet<UserAccount>>();
            mockedUserAccountDbSet.As<IQueryable<UserAccount>>().Setup(m => m.Provider).Returns(accounts.Provider);
            mockedUserAccountDbSet.As<IQueryable<UserAccount>>().Setup(m => m.Expression).Returns(accounts.Expression);
            mockedUserAccountDbSet.As<IQueryable<UserAccount>>().Setup(m => m.ElementType).Returns(accounts.ElementType);
            mockedUserAccountDbSet.As<IQueryable<UserAccount>>().Setup(m => m.GetEnumerator()).Returns(() => accounts.GetEnumerator());

            _mockedUserDbContext.Setup(u => u.UserAccount).Returns(mockedUserAccountDbSet.Object);
        }
    }
}
