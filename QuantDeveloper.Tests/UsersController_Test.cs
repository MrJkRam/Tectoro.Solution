using Moq;
using QuantDeveloper.Api.Controllers;
using QuantDeveloper.Business.Interfaces;
using QuantDeveloper.Business.Models;
using QuantDeveloper.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using QuantDeveloper.Data.Models;
using System.Collections;

namespace QuantDeveloper.Tests
{

    public class UsersController_Test
    {
        [Fact]
        public void Index_ReturnsAJsonResult_WithAListOfUsers()
        {
            // Arrange
            var mockIRepositoryFactory = new Mock<IRepositoryFactory>();
            var mockIUsersService = new Mock<IUsersService>();
            var mockIUsersRepository = new Mock<IUsersRepository>();

            mockIUsersService.Setup(repo => repo.FindAll()).Returns((IQueryable<User>)GetUsers());
            var controller = new UsersController(mockIRepositoryFactory.Object, mockIUsersService.Object);

            // Act
            ActionResult result = controller.All();

            // Assert
            //Assert.Equal(2, 2);

            Assert.Single((System.Collections.IEnumerable)result);

        }

        private List<User> GetUsers()
        {
            var mockResults = new List<User>() {
            new User()
            {
                UserId =1,
                UserName="User1",
                Email="UserOne@user.com",
                Alias="UserOne",
                FirstName= "User FN1",
                LastName= "User LN1"
            },
            new User() {
                UserId =2,
                UserName="User1",
                Email="UserOne@user.com",
                Alias="UserOne",
                FirstName= "User FN1",
                LastName= "User LN1"
            }

            };

            return mockResults;
        }
    }
}
