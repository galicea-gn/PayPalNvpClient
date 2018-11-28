using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PayPalNvpClient.Models;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PayPalNvpClient.Helpers
{
    public static class FormUrlEncodedHelper
    {
        private static IDictionary<string, string> ToKeyValue(object metaToken)
        {
            if (metaToken == null)
            {
                return null;
            }

            JToken token = metaToken as JToken;
            if (token == null)
            {
                return ToKeyValue(JObject.FromObject(metaToken));
            }

            if (token.HasValues)
            {
                var contentData = new Dictionary<string, string>();
                foreach (var child in token.Children())
                {
                    var childContent = ToKeyValue(child);
                    if (childContent != null)
                    {
                        contentData = contentData.Concat(childContent)
                                                 .ToDictionary(k => k.Key, v => v.Value);
                    }
                }

                return contentData;
            }

            var jValue = token as JValue;
            if (jValue?.Value == null)
            {
                return null;
            }
            
            var value = jValue?.Type == JTokenType.Date ?
                            jValue?.ToString("o", CultureInfo.InvariantCulture) :
                            jValue?.ToString(CultureInfo.InvariantCulture);

            return new Dictionary<string, string> { { token.Path, value } };
        }

        public static TResponse FromKeyValues<TResponse>(string response)
        {
            if (response == null)
            {
                return default(TResponse);
            }

            NameValueCollection collection = HttpUtility.ParseQueryString(response);
            string json = JsonConvert.SerializeObject(collection.Cast<string>().ToDictionary(k => k, v => collection[v]));
            return JsonConvert.DeserializeObject<TResponse>(json);
        }

        public static IDictionary<string, string> RequestToNameValueCollection<TResponse>(this IRequest<TResponse> request) where TResponse : class
        {
            return ToKeyValue(request);
        }
    }
}
