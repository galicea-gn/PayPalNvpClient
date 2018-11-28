using Newtonsoft.Json;
using PayPalNvpClient;
using PayPalNvpClient.Enumerations.CharEnumerations;
using PayPalNvpClient.Enumerations.StringEnumerations;
using PayPalNvpClient.Models.BAUpdate;
using PayPalNvpClient.Models.DoReferenceTransaction;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new PayPalNvpClientConfiguration("paypal_api1.peakperformancegolfswing.com", "SKX7VT7DN6W7AY8S", "AFcWxV21C7fd0v3bYYYRCpSSRl31A291zc-1KZaahc8vSuqQwa3MzXKN", "204.0", ApiModeEnum.Live);
            var client = new PayPalNvpApiClient(config);

            DoReferenceTransactionRequest request = new DoReferenceTransactionRequest("B-12U13965606086630", PaymentActionEnum.Sale, 9.97);
            DoReferenceTransactionResponse baUpdate = client.SendRequest(request).Result;
            
            Console.WriteLine(JsonConvert.SerializeObject(baUpdate));
            Console.ReadLine();
        }
    }
}
