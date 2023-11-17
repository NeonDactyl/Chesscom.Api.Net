using Chesscom.Api.Net.Models.Return;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Chesscom.Api.Net.Endpoints
{
    internal class BaseEndpoint<ReturnType> where ReturnType : class
    {
        public HttpClient HttpClient = new HttpClient();
        protected string BaseUrl = "https://api.chess.com/";
        private string DefaultUserAgent;
        public BaseEndpoint(string? defaultUserAgent = null)
        {
            DefaultUserAgent = defaultUserAgent ?? string.Empty;
            HttpClient.DefaultRequestHeaders.Add("User-Agent", HttpUtility.UrlEncode(DefaultUserAgent));
        }

        protected async Task<ReturnType?> GetAsync(string url)
        {
            HttpResponseMessage response = await HttpClient.GetAsync(url);
            var contentString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ReturnType>(contentString);
        }
    }
}
