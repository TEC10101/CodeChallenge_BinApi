using BinApi.Repositories.Bin;
using BinApi.Services.BinMaintenanceSvc;
using BinApi.Services.ItemMaintenanceSvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BinApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinsController : ControllerBase
    {
        private readonly BinDb _context;
        private readonly IBinMaintenanceSvc binMaintenanceSvc;
        private readonly IItemMaintenanceSvc itemMaintenanceSvc;

        public BinsController(BinDb context, IBinMaintenanceSvc binMaintenanceSvc, IItemMaintenanceSvc itemMaintenanceSvc)
        {
            _context = context;
            this.binMaintenanceSvc = binMaintenanceSvc;
            this.itemMaintenanceSvc = itemMaintenanceSvc;
        }

        // GET: api/Bins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bin>>> GetBins()
        {
          if (_context.Bins == null)
          {
              return NotFound();
          }
            return await _context.Bins.ToListAsync();
        }

        // GET: api/Bins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bin>> GetBin(int id)
        {
          if (_context.Bins == null)
          {
              return NotFound();
          }
            var bin = await _context.Bins.FindAsync(id);

            if (bin == null)
            {
                return NotFound();
            }

            return bin;
        }

        // PUT: api/Bins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBin(int id, Bin bin)
        {
            if (id != bin.Id)
            {
                return BadRequest();
            }

            _context.Entry(bin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BinExists(id))
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

        // POST: api/Bins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bin>> PostBin(Bin bin)
        {
          if (_context.Bins == null)
          {
              return Problem("Entity set 'BinDb.Bins'  is null.");
          }
            _context.Bins.Add(bin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBin", new { id = bin.Id }, bin);
        }

        // DELETE: api/Bins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBin(int id)
        {
            if (_context.Bins == null)
            {
                return NotFound();
            }
            var bin = await _context.Bins.FindAsync(id);
            if (bin == null)
            {
                return NotFound();
            }

            _context.Bins.Remove(bin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BinExists(int id)
        {
            return (_context.Bins?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
