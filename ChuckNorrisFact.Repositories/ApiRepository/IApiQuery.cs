using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorrisFact.Repositories.ApiRepository
{
    public interface IApiQuery<T>
    {
        Task<IList<T>> Query();
    }
}
