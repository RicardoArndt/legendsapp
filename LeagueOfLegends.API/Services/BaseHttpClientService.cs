using LeagueOfLegends.API.Endpoints;
using LeagueOfLegends.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends.API.Services
{
    public class BaseHttpClientService : IBaseHttpClientService
    {
        private HttpClient _httpClient;
        private HttpResponseMessage _httpResponseMessage;

        public BaseHttpClientService()
        {
            _httpClient = new HttpClient();
            _httpResponseMessage = new HttpResponseMessage();
        }

        public async Task<string> GetDataAsync(string path)
        {
            _httpResponseMessage = await _httpClient.GetAsync(path);

            try
            {
                return await _httpResponseMessage.Content.ReadAsStringAsync();
            } 
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
