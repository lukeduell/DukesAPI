using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DukesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using DukesAPI.DataAccess;

namespace DukesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly DukesApiDb _context;

        public TeamsController(DukesApiDb context)
        {
            _context = context;
        }

        // GET: api/Teams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamDb>>> GetTeams()
        {
            return await _context.Teams.ToListAsync();
        }

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamDb>> GetTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            return team;
        }

        // POST: api/Teams
        [HttpPost]
        public async Task<ActionResult<TeamDb>> PostTeam(TeamDb team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            // Return the created team with its generated ID
            return CreatedAtAction(nameof(GetTeam), new { id = team.TeamId }, team);
        }

        // PUT: api/Teams/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeam(int id, TeamDb team)
        {
            if (id != team.TeamId)
            {
                return BadRequest();
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.TeamId == id);
        }
    }
}
