using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

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
            try
            {
                var contentString = await ProcessRequest(url);
                return JsonConvert.DeserializeObject<ReturnType>(contentString);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deserializing the response content", ex);
            }
        }

        protected async Task<string> GetFileAsync(string url, string? filePath = null)
        {
            try
            {
                var contentString = await ProcessRequest(url);
                if (filePath != null)
                {
                    File.WriteAllText(filePath, contentString);
                }
                return contentString ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while processing the response content", ex);
            }
        }

        private async Task<string> ProcessRequest(string url)
        {
            try
            {
                HttpResponseMessage response = await HttpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Request failed with status code: {response.StatusCode}");
                }

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException("HTTP request failed", ex);
            }
        }
    }
}
