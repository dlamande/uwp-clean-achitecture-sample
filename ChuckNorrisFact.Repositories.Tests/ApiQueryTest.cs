using ChuckNorrisFact.Repositories.ApiRepository;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Repositories.Tests
{
    [TestClass]
    public class ApiQueryTest
    {
        public MockHttpClient MockHttpClient { get; private set; }

        [TestMethod]
        public async Task TestQuery_Normal_Case()
        {
            var query = new ApiQuery(new MockHttpClient("{\"type\":\"success\", \"value\": [ { \"id\": 1, \"joke\": \"Chuck Norris uses ribbed condoms inside out, so he gets the pleasure.\", \"categories\": [\"explicit\"] }]}"));
            var response = await query.Query();

            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.Count);
        }
    }
}