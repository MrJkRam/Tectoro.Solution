using System;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using QuantDeveloper.Api;
using Xunit;

namespace QuantDeveloper.IntegrationTest
{
    public class UsersControllerApi_Tests
    {
        private readonly HttpClient _httpClient;
        public UsersControllerApi_Tests()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _httpClient = server.CreateClient();
        }

        
        [Fact]
        //[Theory]
        //[InlineData("GET")]
        public async void QuantDeveloperGetAllUsersTestAsync()
        {
            // Arrange
            var request = new HttpRequestMessage(new HttpMethod("GET"), "/api/users/");

            // Act
            var response = await _httpClient.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData(1)]
        public async void QuantDeveloperGetUserByUserIdTestAsync(int? id = null)
        {
            // Arrange
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"/api/users/{id}");

            // Act
            var response = await _httpClient.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
