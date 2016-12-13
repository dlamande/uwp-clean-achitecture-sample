using System.Threading.Tasks;

namespace ChuckNorrisFact
{
    public interface IChuckNorrisView
    {
       void DisplayJokes(JokesViewModel jokesViewModel);
       void DisplayLoader();
       void HideLoader();
    }
}
