using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace GitHubDemoTest
{
    public class SaludoTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public SaludoTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetSaludoDebeRetornar200()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/saludo");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
