using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace iStradaCli.Models
{
    public class iStradaClient
    {
        private readonly HttpClient _httpClient;
        private readonly UserProfile _userProfile;
        private readonly ILogger _logger;

        public iStradaClient(HttpClient httpClient, UserProfile userProfile, ILogger logger)
        {
            _httpClient = httpClient;
            _userProfile = userProfile;
            _logger = logger;
        }

        public async Task<string> GetAsync(string url)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);

            return await Request(requestMessage);
        }

        private Task<string> Request(HttpRequestMessage requestMessage)
        {
            return Task.FromResult("");
        }

        public Task<string> GetTokenAsync()
        {
            return Task.FromResult("");
        }
    }
}