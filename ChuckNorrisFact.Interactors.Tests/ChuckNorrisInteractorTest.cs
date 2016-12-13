using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using ChuckNorrisFact.Interactors.Tests.Mock;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Interactors.Tests
{
    [TestClass]
    public class ChuckNorrisInteractorTest
    {
        [TestMethod]
        public async Task ChuckNorrisInteractorTest_Normal_Case()
        {
            ChuckNorrisInteractor chuckNorrisInteractor = new ChuckNorrisInteractor(new MockApiQuery());
            var jokes = await chuckNorrisInteractor.Jokes();
            Assert.IsNotNull(jokes);
            Assert.AreEqual(2,jokes.Count);
            Assert.AreEqual("A new joke", jokes[0].Label);
            Assert.AreEqual("some joke", jokes[1].Label);
        }
    }
}
