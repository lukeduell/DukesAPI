using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukesAPI.DataAccess
{
    public class ESPNDataAccess
    {
        private readonly HttpClient _httpClient;
        public ESPNDataAccess(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetCollegeFootballDataAsync()
        {
            try
            {
                string url = "https://api.espn.com/v1/sports/football/college-football/events";
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                // Handle any errors that occur during the request
                Console.WriteLine($"An error occurred: {e.Message}");
                return null;
            }
        }
    }
}
