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
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]

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
    }
}
