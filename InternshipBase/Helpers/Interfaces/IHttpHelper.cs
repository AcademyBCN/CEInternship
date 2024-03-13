using System.Threading.Tasks;

namespace InternshipBase.Helpers.Interfaces
{
    public interface IHttpHelper
    {
        Task<string> Get(string url);
    }
}
