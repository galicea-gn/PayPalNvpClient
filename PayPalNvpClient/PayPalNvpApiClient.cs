using PayPalNvpClient.Helpers;
using PayPalNvpClient.Models;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PayPalNvpClient
{
    public class PayPalNvpApiClient : IPayPalNvpApiClient
    {
        private readonly IRestClient _restClient;
        private IPayPalNvpClientConfiguration _config { get; }

        public PayPalNvpApiClient(IPayPalNvpClientConfiguration configuration)
        {
            _config = configuration;
            _restClient = _restClient == null ? new RestClient() : _restClient;
        }

        public PayPalNvpApiClient(IPayPalNvpClientConfiguration configuration, IRestClient client)
            : this(configuration)
        {
            _config = configuration;
            _restClient = client;
        }

        public async Task<TResponse> SendRequest<TResponse>(IRequest<TResponse> request) where TResponse : class
        {
            if (request == null || !request.IsValidRequest())
            {
                return null;
            }

            var nameValueContent = _config.GetCommonKeyValues().Concat(request.RequestToNameValueCollection());

            using (HttpResponseMessage response = await _restClient.SendPostRequest(_config.Url, new FormUrlEncodedContent(nameValueContent)))
            {
                string responseString = await response.Content.ReadAsStringAsync();
                return request.GenerateResponseObject(responseString);
            }
        }
    }

    public interface IPayPalNvpApiClient
    {
        Task<TResponse> SendRequest<TResponse>(IRequest<TResponse> request) where TResponse : class;
    }
}
