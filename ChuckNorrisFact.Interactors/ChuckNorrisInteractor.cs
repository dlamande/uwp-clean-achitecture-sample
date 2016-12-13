using ChuckNorrisFact.Repositories.ApiRepository;
using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ChuckNorrisFact.Interactors
{
    public class ChuckNorrisInteractor : IChuckNorrisInteractor
    {
        private IApiQuery<ChuckNorrisJoke> _repos;
        public ChuckNorrisInteractor(IApiQuery<ChuckNorrisJoke> repos)
       { 
            _repos = repos;
        }

        public async Task<IList<ChuckNorrisJoke>> Jokes()
        {
            return (await _repos.Query()).OrderBy(joke => joke.Label).ToList();
        }
    }
}
