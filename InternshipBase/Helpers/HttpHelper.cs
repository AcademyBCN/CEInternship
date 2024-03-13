using InternshipBase.Helpers.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace InternshipBase.Helpers
{
    public class HttpHelper : IHttpHelper
    {

        private readonly HttpClient _client;

        //Create a builder for this class
        public HttpHelper()
        {
            _client = new HttpClient();
        }

        public async Task<string> Get(string url)
        {
            var response = await _client.GetStringAsync(url);
            return response;
        }

    }
}
