using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using ChuckNorrisFact.Tests.Mock;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Tests
{
    [TestClass]
    public class ChuckNorrisPresenterTest
    {
        private ChuckNorrisPresenter _presenter;

        [TestMethod]
        public void TestLoad_Nominal_Case()
        {
            var view = new MockChuckNorrisView();
            _presenter = new ChuckNorrisPresenter(view, new MockChuckNorrisInteractor());
            var task = _presenter.Load();

            task.Wait();

            Assert.AreEqual(1, view.GetQueue().Dequeue(), 1);
            Assert.AreEqual(2, view.GetQueue().Dequeue(), 2);
            Assert.AreEqual(3, view.GetQueue().Dequeue(), 3);

            var jokeViewModel = view.GetJokesViewModel();

            Assert.AreEqual(1, jokeViewModel.Jokes.Count, 1);
            Assert.AreEqual("There is 1 joke(s)", jokeViewModel.NbJokesLabel);
        }
    }
}
