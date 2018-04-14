using EntityFramework.MoqHelper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MVC.Models.Models;
using MVC.Repository.EntityFramework.DbContexts.Base;
using MVC.Repository.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Repository.EntityFramework.Test
{
    [TestClass]
    public class UserAccountRepositoryTest
    {
        Mock<MvcBankEntities1> _mockContext;
        List<User> _users;

        [TestInitialize]
        public void Initialize()
        {
            _users = new List<User>
            {
                new User{
                    UserType = (byte)Models.Enums.AccountType.PowerUser,
                    MailId = "gibson.thomas@ust-global.com",
                    Password = "chanakya",
                    UniqueId = Guid.NewGuid(),
                    Username = "gibsonthomas",
                    Id = 3
                }
            };

            var mockSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(_users)
                .WithAdd(_users, "Id")
                .WithFind(_users, "Id")
                .WithRemove(_users);

            _mockContext =
                EntityFrameworkMoqHelper
                .CreateMockForDbContext<MvcBankEntities1, User>(mockSet);

            //AutoMapper.Initialize();
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

        [TestMethod]
        public void GetUser_ValidUsername_GetsUserTest()
        {
            // Arrange
            var repository = new UserAccountRepository(_mockContext.Object);

            // Act
            var user = repository.GetUser("gibsonthomas");
            var result = AutoMapper.Mapper.Map<UserModel, User>(user);

            // Assert
            Assert.IsNotNull(result);
            result.Should().BeEquivalentTo(_users.First());
        }

        [TestMethod]
        public void GetUser_InvalidUsername_FailsTest()
        {
            // Arrange
            var repository = new UserAccountRepository(_mockContext.Object);

            // Act
            var result = repository.GetUser("gibsonthomas1");

            // Assert
            Assert.IsNull(result);
        }
    }
}
