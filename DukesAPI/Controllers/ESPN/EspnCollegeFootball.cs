using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DukesAPI.DataAccess;
using DukesAPI.Models;

namespace DukesAPI.Controllers.ESPN
{
    [Route("api/espn/college-football")]
    [ApiController]
    //[Authorize]

    public class EspnCollegeFootball: ControllerBase
    {
        private readonly IESPNDataAccess _dataAccess;

        public EspnCollegeFootball(IESPNDataAccess dataaccess)
        {
            _dataAccess = dataaccess;
        }

        //GET api/<EspnCollegeFootballNews>/5
        ///<summary>
        ///Returns news from college football
        ///</summary>
        ///<returns>College football news</returns>
        [HttpGet("GetCFBNews")]
        public ActionResult<NewsResponse> GetCollegeFootballNews()
        {
            Console.WriteLine("ESPN/EspnCollegeFootball", "GET", "Get all news");

            try
            {
                return _dataAccess.GetCollegeFootballDataAsync().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error using ESPN/EspnCollegeFootball GET all news", ex.Message);
                return BadRequest(ex.Message);
            }
        }
        //GET api/<EspnCollegeFootballScores>/5
        ///<summary>
        ///Returns scores from college football
        ///</summary>
        ///<returns>College football scores</returns>
        [HttpGet("GetCFBScores")]
        public ActionResult<Scores> GetCollegeFootballScores()
        {
            Console.WriteLine("ESPN/EspnCollegeFootball", "GET", "Get all scores");

            try
            {
                return _dataAccess.GetCollegeFootballScoresAsync().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error using ESPN/EspnCollegeFootball GET all news", ex.Message);
                return BadRequest(ex.Message);
            }
        }
        // GET api/<EspnCollegeFootballGames>/5
        /// <summary>
        /// Returns scores for a specific college football game.
        /// </summary>
        /// <param name="gameId">The ID of the game to retrieve information for. EX: gameId = 401628566</param>
        /// <returns>College football scores for the specified game.</returns>
        [HttpGet("GetCFBGameInformation/{gameId}")]
        public ActionResult<EventSummary> GetCollegeFootballGameInformation(string gameId)
        {
            Console.WriteLine("ESPN/EspnCollegeFootball", "GET", $"Fetching scores for gameId: {gameId}");

            try
            {
                var gameInformation = _dataAccess.GetCollegeFootballGameInformationAsync(gameId).Result;
                return Ok(gameInformation);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching scores for gameId {gameId}: {ex.Message}");
                return BadRequest(new { Message = "An error occurred while fetching game information.", Details = ex.Message });
            }
        }
        // GET api/<EspnCollegeFootballTeams>/GetCFBTeamInformation/194
        /// <summary>
        /// Returns team information based on the team ID.
        /// </summary>
        /// <param name="teamId">The ID of the team to retrieve information for. Example: teamId = 194</param>
        /// <returns>College football team information.</returns>
        [HttpGet("GetCFBTeamInformation/{teamId}")]
        public ActionResult<TeamModel> GetCollegeFootballTeamInformationAsync(string teamId)
        {
            Console.WriteLine($"ESPN/EspnCollegeFootball", "GET", $"Fetching team information for teamId: {teamId}");

            try
            {
                var teamInformation = _dataAccess.GetCollegeFootballTeamInformationAsync(teamId).Result;
                return Ok(teamInformation);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching team information for teamId {teamId}: {ex.Message}");
                return BadRequest(new { Message = "An error occurred while fetching team information.", Details = ex.Message });
            }
        }

        // GET api/<EspnCollegeFootballRankings>/GetCFBRankings/
        /// <summary>
        /// Returns college football rankings.
        /// </summary>
        /// <returns>College football rankings.</returns>
        [HttpGet("GetCFBRankings")]
        public ActionResult<RankingsModel> GetCollegeFootballRankingsAsync()
        {
            Console.WriteLine($"ESPN/EspnCollegeFootball", "GET", $"Fetching CFB rankings");

            try
            {
                var teamInformation = _dataAccess.GetCollegeFootballRankingsAsync().Result;
                return Ok(teamInformation);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching rankings: {ex.Message}");
                return BadRequest(new { Message = "An error occurred while fetching rankings", Details = ex.Message });
            }
        }

    }
}
