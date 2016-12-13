using ChuckNorrisFact.Repositories;
using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Interactors
{
    public interface IChuckNorrisInteractor
    {
        Task<IList<ChuckNorrisJoke>> Jokes();
    }
}
