using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient
{
    public class PayPalNvpClientConfiguration : IPayPalNvpClientConfiguration
    {
        public const string SandboxUrl = "https://api-3t.sandbox.paypal.com/nvp";
        public const string LiveUrl = "https://api-3t.paypal.com/nvp";

        public string Url { get; }
        internal string Username { get; }
        internal string Password { get; }
        internal string Signature { get; }
        internal string Version { get; }

        public PayPalNvpClientConfiguration(
            string username,
            string password,
            string signature,
            string version,
            ApiModeEnum mode)
        {
            Username = username;
            Password = password;
            Signature = signature;
            Version = version;
            Url = mode == ApiModeEnum.Live ? LiveUrl : SandboxUrl;
        }

        public IDictionary<string, string> GetCommonKeyValues() =>
            new Dictionary<string, string>()
            {
                { "USER", Username },
                { "PWD", Password },
                { "SIGNATURE", Signature },
                { "VERSION", Version }
            };
    }

    public interface IPayPalNvpClientConfiguration
    {
        string Url { get; }
        IDictionary<string, string> GetCommonKeyValues();
    }

    public enum ApiModeEnum
    {
        Sandbox = 0,
        Live = 1
    }
}
