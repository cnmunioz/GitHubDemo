using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Text.Json;

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

            var response = await client.GetAsync("/api/demo");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetSaludoCorrecto()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/demo");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var contenido = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(contenido);

            Assert.Equal(
                "Hola Mundo",
                doc.RootElement.GetProperty("mensaje").GetString()
            );
        }

        [Fact]
        public async Task Post_EjecucionCorrecta()
        {
            var client = _factory.CreateClient();

            var response = await client.PostAsync("/api/demo", null);

            var contenido = await response.Content.ReadAsStringAsync();

            Assert.Equal("POST ejecutado", contenido);
        }

        [Fact]
        public async Task Put_Id()
        {
            var client = _factory.CreateClient();

            var response = await client.PutAsync("/api/demo/5", null);

            var contenido = await response.Content.ReadAsStringAsync();

            Assert.Equal("PUT ejecutado para 5", contenido);
        }

        [Fact]
        public async Task Delete_Id()
        {
            var client = _factory.CreateClient();

            var response = await client.DeleteAsync("/api/demo/10");

            var contenido = await response.Content.ReadAsStringAsync();

            Assert.Equal("DELETE ejecutado para 10", contenido);
        }
    }



}
