using System.Collections.Generic;
using System.Threading.Tasks;

namespace UWPGurdianPROJ.Core.ViewModels
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(string baseUrl, Dictionary<string, string> parameters);
    }
}