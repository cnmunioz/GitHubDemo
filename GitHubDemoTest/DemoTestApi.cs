using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace GitHubDemoTest
{
    public class DemoTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public DemoTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetDemoDebeRetornar200()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/demo");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
