using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DukesAPI.Models;

namespace DukesAPI.DataAccess
{
    public class ESPNDataAccess
    {
        private readonly HttpClient _httpClient;
        public ESPNDataAccess(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NewsResponse> GetCollegeFootballDataAsync()
        {
            string url = "http://site.api.espn.com/apis/site/v2/sports/football/college-football/news";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var newsData = JsonSerializer.Deserialize<NewsResponse>(responseBody);
                return newsData;
            }
            catch (HttpRequestException e)
            {
                // Handle errors that occur during the request
                Console.WriteLine($"An error occurred: {e.Message}");
                return null;
            }
        }
    }
}
