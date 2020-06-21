using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuantDeveloper.Business.Models;
using System.Collections.Generic;

namespace QuantDeveloper.Tests
{
    [TestClass]
    public class UsersService_Test
    {
        [TestMethod]
        [Description("Can Successfully Retrieve Users list via API")]
        public void CanRetrieveUserList_Test()
        {
           
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
