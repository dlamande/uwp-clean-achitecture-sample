using ChuckNorrisFact.Interactors;
using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;

namespace ChuckNorrisFact
{
    public class ChuckNorrisPresenter : IChuckNorrisPresenter
    {
        private IChuckNorrisView _view;

        public ChuckNorrisPresenter(IChuckNorrisView view)
        {
            _view = view;
        }

        public void PresentJokoes(IList<ChuckNorrisJoke> Jokes)
        {
            _view.DisplayJokes(new JokesViewModel
            {
                NbJokesLabel = string.Format("There is {0} joke(s)", Jokes.Count),
                Jokes = Jokes
            });
        }
    }
}