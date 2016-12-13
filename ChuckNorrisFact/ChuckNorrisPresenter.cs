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

        public void PresentJokes(IList<ChuckNorrisJoke> jokes)
        {
            var viewModel = BuildViewModel(jokes);
            viewModel.Title = "This list is sorted by [A-Z]";
            _view.DisplayJokes(viewModel);
        }

        public void PresentJokesSortedByZA(IList<ChuckNorrisJoke> jokes)
        {
            var viewModel = BuildViewModel(jokes);
            viewModel.Title = "This list is sorted by [Z-A]";
            _view.DisplayJokes(viewModel);
        }

        private JokesViewModel BuildViewModel(IList<ChuckNorrisJoke> jokes)
        {
            return new JokesViewModel
            {
                NbJokesLabel = string.Format("There is {0} joke(s)", jokes.Count),
                Jokes = jokes,
            };
        }
    }
}