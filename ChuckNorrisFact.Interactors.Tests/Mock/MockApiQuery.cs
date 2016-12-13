using ChuckNorrisFact.Repositories.ApiRepository;
using ChuckNorrisFact.Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Interactors.Tests.Mock
{
    public class MockApiQuery : IApiQuery<ChuckNorrisJoke>
    {
        public async Task<IList<ChuckNorrisJoke>> Query()
        {
            return await Task.FromResult(new List<ChuckNorrisJoke> { new ChuckNorrisJoke { Label = "some joke" },
            new ChuckNorrisJoke { Label = "A new joke" } });
        }
    }
}
