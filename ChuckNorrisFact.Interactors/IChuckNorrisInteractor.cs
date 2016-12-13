using System.Threading.Tasks;

namespace ChuckNorrisFact.Interactors
{
    public interface IChuckNorrisInteractor
    {
        Task FetchJokes();

        Task FetchJokensOrderByZA();
    }
}
