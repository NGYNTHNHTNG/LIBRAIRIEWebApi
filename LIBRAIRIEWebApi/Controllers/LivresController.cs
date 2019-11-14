using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LIBRAIRIEWebApi.Models;

namespace LIBRAIRIEWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivresController : ControllerBase
    {
        private readonly LIBRAIRIEContext _context;

        public LivresController(LIBRAIRIEContext context)
        {
            _context = context;
        }

        // GET: api/Livres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livre>>> GetLivre()
        {
            return await _context.Livre.ToListAsync();
        }

        // GET: api/Livres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Livre>> GetLivre(string id)
        {
            var livre = await _context.Livre.FindAsync(id);

            if (livre == null)
            {
                return NotFound();
            }

            return livre;
        }

        // PUT: api/Livres/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLivre(string id, Livre livre)
        {
            if (id != livre.Bookisbn13)
            {
                return BadRequest();
            }

            _context.Entry(livre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivreExists(id))
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

        // POST: api/Livres
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Livre>> PostLivre(Livre livre)
        {
            _context.Livre.Add(livre);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LivreExists(livre.Bookisbn13))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLivre", new { id = livre.Bookisbn13 }, livre);
        }

        // DELETE: api/Livres/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Livre>> DeleteLivre(string id)
        {
            var livre = await _context.Livre.FindAsync(id);
            if (livre == null)
            {
                return NotFound();
            }

            _context.Livre.Remove(livre);
            await _context.SaveChangesAsync();

            return livre;
        }

        private bool LivreExists(string id)
        {
            return _context.Livre.Any(e => e.Bookisbn13 == id);
        }
    }
}
