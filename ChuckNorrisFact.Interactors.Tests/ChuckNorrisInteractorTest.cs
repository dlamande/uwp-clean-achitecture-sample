using ChuckNorrisFact.Interactors.Tests.Mock;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Interactors.Tests
{
    [TestClass]
    public class ChuckNorrisInteractorTest
    {
        [TestMethod]
        public async Task ChuckNorrisInteractorTest_Normal_Case()
        {
            var mockChuckNorrisPresenter = new MockChuckNorrisPresenter();
            ChuckNorrisInteractor chuckNorrisInteractor = new ChuckNorrisInteractor(mockChuckNorrisPresenter, new MockApiQuery());
            await chuckNorrisInteractor.FetchJokes();
            Assert.IsNotNull(mockChuckNorrisPresenter.Jokes);
            Assert.AreEqual(2, mockChuckNorrisPresenter.Jokes.Count);
            Assert.AreEqual("A new joke", mockChuckNorrisPresenter.Jokes[0].Label);
            Assert.AreEqual("some joke", mockChuckNorrisPresenter.Jokes[1].Label);
        }

        [TestMethod]
        public async Task GivenJokes_WhenFetchJokensOrderByZA_ThenJokesShouldBeOrdered()
        {
            var mockChuckNorrisPresenter = new MockChuckNorrisPresenter();
            ChuckNorrisInteractor chuckNorrisInteractor = new ChuckNorrisInteractor(mockChuckNorrisPresenter, new MockApiQuery());
            await chuckNorrisInteractor.FetchJokensOrderByZA();
            Assert.IsNotNull(mockChuckNorrisPresenter.Jokes);
            Assert.AreEqual(2, mockChuckNorrisPresenter.Jokes.Count);
            Assert.AreEqual("some joke", mockChuckNorrisPresenter.Jokes[0].Label);
            Assert.AreEqual("A new joke", mockChuckNorrisPresenter.Jokes[1].Label);
        }
    }
}
