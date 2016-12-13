using ChuckNorrisFact.Interactors;
using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Tests.Mock
{
    public class MockChuckNorrisInteractor : IChuckNorrisInteractor
    {
        public async Task<IList<ChuckNorrisJoke>> Jokes()
        {
            return await Task.FromResult(new List<ChuckNorrisJoke>
            {
                new ChuckNorrisJoke { Label = "My Joke" }
            });
        }
    }
}
