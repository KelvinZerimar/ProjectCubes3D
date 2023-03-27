namespace Cubic3D.Test
{
    using Cube3D.API.ModelDTO;
    using Microsoft.AspNetCore.Mvc.Testing;
    using System.Net;
    using System.Net.Http.Json;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestSuccess()
        {
            using var application = new WebApplicationFactory<Program>();

            var client = application.CreateClient();
            // HTTP POST
            IEnumerable<CubeDTO> cubes = new List<CubeDTO>{
                new CubeDTO("2.5,1.3,9", "10,5"),
                new CubeDTO("7.4,5,1.2", "7,4")}.AsEnumerable();
            var response = await client.PostAsJsonAsync("/api/Cube", cubes);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}