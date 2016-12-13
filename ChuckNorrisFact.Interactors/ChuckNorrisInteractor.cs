using ChuckNorrisFact.Repositories.ApiRepository;
using ChuckNorrisFact.Repositories.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Interactors
{
    public class ChuckNorrisInteractor : IChuckNorrisInteractor
    {
        private IChuckNorrisPresenter _presenter;
        private IApiQuery<ChuckNorrisJoke> _repos;

        public ChuckNorrisInteractor(IChuckNorrisPresenter presenter, IApiQuery<ChuckNorrisJoke> repos)
        {
            _repos = repos;
            _presenter = presenter;
        }

        public async Task FetchJokes()
        {
            var jokes = (await _repos.Query()).OrderBy(joke => joke.Label).ToList();
            _presenter.PresentJokes(jokes);
        }

        public async Task FetchJokensOrderByZA()
        {
            var jokes = (await _repos.Query()).OrderByDescending(joke => joke.Label).ToList();
            _presenter.PresentJokesSortedByZA(jokes);
        }
    }
}
