using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CollabCRUD.Data;
using CollabCRUD.Models;

namespace CollabCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickController : ControllerBase
    {
        private readonly APIDbContext _context;

        public PickController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Pick
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pick>>> GetPicks()
        {
          if (_context.Picks == null)
          {
              return NotFound();
          }
            return await _context.Picks.ToListAsync();
        }

        // GET: api/Pick/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pick>> GetPick(int id)
        {
          if (_context.Picks == null)
          {
              return NotFound();
          }
            var pick = await _context.Picks.FindAsync(id);

            if (pick == null)
            {
                return NotFound();
            }

            return pick;
        }

        // PUT: api/Pick/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPick(int id, Pick pick)
        {
            if (id != pick.PickId)
            {
                return BadRequest();
            }

            _context.Entry(pick).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PickExists(id))
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

        // POST: api/Pick
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pick>> PostPick(Pick pick)
        {
          if (_context.Picks == null)
          {
              return Problem("Entity set 'APIDbContext.Picks'  is null.");
          }
            _context.Picks.Add(pick);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPick", new { id = pick.PickId }, pick);
        }

        // DELETE: api/Pick/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePick(int id)
        {
            if (_context.Picks == null)
            {
                return NotFound();
            }
            var pick = await _context.Picks.FindAsync(id);
            if (pick == null)
            {
                return NotFound();
            }

            _context.Picks.Remove(pick);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PickExists(int id)
        {
            return (_context.Picks?.Any(e => e.PickId == id)).GetValueOrDefault();
        }
    }
}
