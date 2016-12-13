using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;

namespace ChuckNorrisFact.Interactors
{
    public interface IChuckNorrisPresenter
    {
        void PresentJokes(IList<ChuckNorrisJoke> Jokes);
        void PresentJokesSortedByZA(IList<ChuckNorrisJoke> Jokes);

    }
}
