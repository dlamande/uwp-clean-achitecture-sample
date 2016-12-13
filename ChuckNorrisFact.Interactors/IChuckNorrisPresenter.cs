using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;

namespace ChuckNorrisFact.Interactors
{
    public interface IChuckNorrisPresenter
    {
        void PresentJokoes(IList<ChuckNorrisJoke> Jokes);
    }
}
