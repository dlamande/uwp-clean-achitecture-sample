using System.Threading.Tasks;

namespace ChuckNorrisFact.Repositories.ApiRepository
{
    public interface IHttpClient
    {
        Task<string> GetString(string url);
    }
}
