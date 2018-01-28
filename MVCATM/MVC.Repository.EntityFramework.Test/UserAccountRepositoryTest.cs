using EntityFramework.MoqHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVC.Models.Models;
using MVC.Repository.EntityFramework.DbContexts.Base;
using MVC.Repository.EntityFramework.Repositories;
using System;
using System.Collections.Generic;

namespace MVC.Repository.EntityFramework.Test
{
    [TestClass]
    public class UserAccountRepositoryTest
    {
        Mock<UserDbContextBase> _mockContext;

        [TestInitialize]
        public void Initialize()
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
            };

            var mockSet = EntityFrameworkMoqHelper.CreateMockForDbSet<UserAccount>()
                .SetupForQueryOn(accounts)
                .WithAdd(accounts, "UniqueId")
                .WithFind(accounts, "UniqueId")
                .WithRemove(accounts);

            _mockContext =
                EntityFrameworkMoqHelper
                .CreateMockForDbContext<UserDbContextBase, UserAccount>(mockSet);
        }

        [TestMethod]
        public void Login_ValidCredentials_ValidatesSuccessfullyTest()
        {
            // Arrange
            var repository = new UserAccountRepository(_mockContext.Object);

            // Act
            var result = repository.Login("gibsonthomas", "chanakya");

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Login_InvalidCredentials_FailsTest()
        {
            // Arrange
            var repository = new UserAccountRepository(_mockContext.Object);

            // Act
            var result = repository.Login("gibsonthomas1", "chanakya1");

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
