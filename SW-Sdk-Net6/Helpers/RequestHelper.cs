﻿using System.Net;

namespace SW.Helpers
{
    internal class RequestHelper
    {
        internal static HttpClientHandler ProxySettings(string proxy, int proxyPort)
        {
            if (!string.IsNullOrEmpty(proxy))
            {
                HttpClientHandler httpClientHandler = new ()
                {
                    Proxy = new WebProxy(string.Format("{0}:{1}", proxy, proxyPort), false),
                    UseProxy = true
                };
                return httpClientHandler;
            }
            else
            {
                return new HttpClientHandler();
            }
        }
        internal static async Task<Dictionary<string, string>> SetupAuthHeaderAsync(Services.Services services)
        {
            var setup = await services.SetupAuthAsync();
            Dictionary<string, string> headers = new()
            {
                { "Authorization", "bearer " + setup.Token }
            };
            return headers;
        }
        internal static Dictionary<string, string> SetupHeaders(Dictionary<string, string> headers, string customId = null, string[] emails = null, bool pdf = false)
        {
            if(customId != null)
            {
                headers.Add("customid", customId);
            }
            if(emails != null)
            {
                var emailHeader = String.Join(',', emails);
                headers.Add("email", emailHeader);
            }
            if (pdf)
            {
                headers.Add("pdf", String.Empty);
            }
            return headers;
        }
        internal static Dictionary<string, string> SetupHeaders(string user, string password) => new() { { "user", user }, { "password", password } };
    }
}