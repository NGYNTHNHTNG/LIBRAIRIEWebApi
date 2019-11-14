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
    public class AuteursController : ControllerBase
    {
        private readonly LIBRAIRIEContext _context;

        public AuteursController(LIBRAIRIEContext context)
        {
            _context = context;
        }

        // GET: api/Auteurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Auteur>>> GetAuteur()
        {
            return await _context.Auteur.ToListAsync();
        }

        // GET: api/Auteurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Auteur>> GetAuteur(int id)
        {
            var auteur = await _context.Auteur.FindAsync(id);

            if (auteur == null)
            {
                return NotFound();
            }

            return auteur;
        }

        // PUT: api/Auteurs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuteur(int id, Auteur auteur)
        {
            if (id != auteur.Authorid)
            {
                return BadRequest();
            }

            _context.Entry(auteur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuteurExists(id))
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

        // POST: api/Auteurs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Auteur>> PostAuteur(Auteur auteur)
        {
            _context.Auteur.Add(auteur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuteur", new { id = auteur.Authorid }, auteur);
        }

        // DELETE: api/Auteurs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Auteur>> DeleteAuteur(int id)
        {
            var auteur = await _context.Auteur.FindAsync(id);
            if (auteur == null)
            {
                return NotFound();
            }

            _context.Auteur.Remove(auteur);
            await _context.SaveChangesAsync();

            return auteur;
        }

        private bool AuteurExists(int id)
        {
            return _context.Auteur.Any(e => e.Authorid == id);
        }
    }
}
