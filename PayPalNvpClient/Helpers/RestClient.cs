using System.Net.Http;
using System.Threading.Tasks;

namespace PayPalNvpClient.Helpers
{
    public class RestClient : IRestClient
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<HttpResponseMessage> SendPostRequest(string uri, HttpContent content)
        {
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri) { Content = content })
            {
                return await _client.SendAsync(request);
            }
        }
    }

    public interface IRestClient
    {
        Task<HttpResponseMessage> SendPostRequest(string uri, HttpContent content);
    }
}
