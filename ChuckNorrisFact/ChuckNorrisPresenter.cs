using ChuckNorrisFact.Interactors;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisFact
{
    public class ChuckNorrisPresenter
    {
        private IChuckNorrisInteractor _interactor;
        private IChuckNorrisView _view;

        public ChuckNorrisPresenter(IChuckNorrisView view, IChuckNorrisInteractor interactor)
        {
            _view = view;
            _interactor = interactor;
        }

        public async Task Load()
        {
            await Task.Delay(2000);
            _view.DisplayLoader();
            var jokesTask = await _interactor.Jokes();
            await Task.Delay(2000);
            _view.DisplayJokes(new JokesViewModel
            {
                NbJokesLabel = string.Format("There is {0} joke(s)", jokesTask.Count()),
                Jokes = jokesTask
            });

            _view.HideLoader();
        }
    }
}
