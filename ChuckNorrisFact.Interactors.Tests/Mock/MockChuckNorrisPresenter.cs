using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChuckNorrisFact.Repositories.Entities;

namespace ChuckNorrisFact.Interactors.Tests.Mock
{
    public class MockChuckNorrisPresenter : IChuckNorrisPresenter
    {
        public IList<ChuckNorrisJoke> Jokes { get; set; }

        public void PresentJokoes(IList<ChuckNorrisJoke> jokes)
        {
            this.Jokes = jokes;
        }
    }
}
