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
    public class EditeursController : ControllerBase
    {
        private readonly LIBRAIRIEContext _context;

        public EditeursController(LIBRAIRIEContext context)
        {
            _context = context;
        }

        // GET: api/Editeurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Editeur>>> GetEditeur()
        {
            return await _context.Editeur.ToListAsync();
        }

        // GET: api/Editeurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Editeur>> GetEditeur(int id)
        {
            var editeur = await _context.Editeur.FindAsync(id);

            if (editeur == null)
            {
                return NotFound();
            }

            return editeur;
        }

        // PUT: api/Editeurs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEditeur(int id, Editeur editeur)
        {
            if (id != editeur.Publisherid)
            {
                return BadRequest();
            }

            _context.Entry(editeur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EditeurExists(id))
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

        // POST: api/Editeurs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Editeur>> PostEditeur(Editeur editeur)
        {
            _context.Editeur.Add(editeur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEditeur", new { id = editeur.Publisherid }, editeur);
        }

        // DELETE: api/Editeurs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Editeur>> DeleteEditeur(int id)
        {
            var editeur = await _context.Editeur.FindAsync(id);
            if (editeur == null)
            {
                return NotFound();
            }

            _context.Editeur.Remove(editeur);
            await _context.SaveChangesAsync();

            return editeur;
        }

        private bool EditeurExists(int id)
        {
            return _context.Editeur.Any(e => e.Publisherid == id);
        }
    }
}
