using ChuckNorrisFact.Repositories.Entities;
using ChuckNorrisFact.Tests.Mock;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Collections.Generic;

namespace ChuckNorrisFact.Tests
{
    [TestClass]
    public class ChuckNorrisPresenterTest
    {
        private ChuckNorrisPresenter _presenter;

        [TestMethod]
        public void TestPresentJokoes_Nominal_Case()
        {
            var view = new MockChuckNorrisView();
            _presenter = new ChuckNorrisPresenter(view);
            _presenter.PresentJokoes(new List<ChuckNorrisJoke> { new ChuckNorrisJoke() });

            var jokeViewModel = view.GetJokesViewModel();

            Assert.AreEqual(1, jokeViewModel.Jokes.Count);
            Assert.AreEqual("There is 1 joke(s)", jokeViewModel.NbJokesLabel);
        }
    }
}
