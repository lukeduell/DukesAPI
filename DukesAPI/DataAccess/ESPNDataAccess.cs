using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DukesAPI.Models;

namespace DukesAPI.DataAccess
{
    public class ESPNDataAccess : IESPNDataAccess
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
                var settings = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var newsData = JsonSerializer.Deserialize<NewsResponse>(responseBody, settings);
                return newsData;
            }
            catch (HttpRequestException e)
            {
                // Handle errors that occur during the request
                Console.WriteLine($"An error occurred: {e.Message}");
                return null;
            }
        }
        public async Task<Scores> GetCollegeFootballScoresAsync()
        {
            string url = "http://site.api.espn.com/apis/site/v2/sports/football/college-football/scoreboard";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var settings = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = false
                };
                var scoresData = JsonSerializer.Deserialize<Scores>(responseBody, settings);
                return scoresData;
            }
            catch (HttpRequestException e)
            {
                // Handle errors that occur during the request
                Console.WriteLine($"An error occurred: {e.Message}");
                return null;
            }
        }
        public async Task<EventSummary> GetCollegeFootballGameInformationAsync(string gameId)
        {
            string url = $"http://site.api.espn.com/apis/site/v2/sports/football/college-football/summary?event={gameId}";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var settings = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = false
                };
                var scoresData = JsonSerializer.Deserialize<EventSummary>(responseBody, settings);
                return scoresData;
            }
            catch (HttpRequestException e)
            {
                // Handle errors that occur during the request
                Console.WriteLine($"An error occurred: {e.Message}");
                return null;
            }
        }
        public async Task<TeamModel> GetCollegeFootballTeamInformationAsync(string teamName)
        {
            string url = $"http://site.api.espn.com/apis/site/v2/sports/football/college-football/teams/{teamName}";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var settings = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = false
                };
                var teamData = JsonSerializer.Deserialize<TeamModel>(responseBody, settings);
                return teamData;
            }
            catch (HttpRequestException e)
            {
                // Handle errors that occur during the request
                Console.WriteLine($"An error occurred: {e.Message}");
                return null;
            }
        }
        public async Task<RankingsModel> GetCollegeFootballRankingsAsync()
        {
            string url = $"http://site.api.espn.com/apis/site/v2/sports/football/college-football/rankings";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var settings = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = false
                };
                var rankingsData = JsonSerializer.Deserialize<RankingsModel>(responseBody, settings);
                return rankingsData;
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
