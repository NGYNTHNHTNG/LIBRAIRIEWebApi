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
    public class ThemesController : ControllerBase
    {
        private readonly LIBRAIRIEContext _context;

        public ThemesController(LIBRAIRIEContext context)
        {
            _context = context;
        }

        // GET: api/Themes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Theme>>> GetTheme()
        {
            return await _context.Theme.ToListAsync();
        }

        // GET: api/Themes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Theme>> GetTheme(int id)
        {
            var theme = await _context.Theme.FindAsync(id);

            if (theme == null)
            {
                return NotFound();
            }

            return theme;
        }

        // PUT: api/Themes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheme(int id, Theme theme)
        {
            if (id != theme.Themeid)
            {
                return BadRequest();
            }

            _context.Entry(theme).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThemeExists(id))
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

        // POST: api/Themes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Theme>> PostTheme(Theme theme)
        {
            _context.Theme.Add(theme);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheme", new { id = theme.Themeid }, theme);
        }

        // DELETE: api/Themes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Theme>> DeleteTheme(int id)
        {
            var theme = await _context.Theme.FindAsync(id);
            if (theme == null)
            {
                return NotFound();
            }

            _context.Theme.Remove(theme);
            await _context.SaveChangesAsync();

            return theme;
        }

        private bool ThemeExists(int id)
        {
            return _context.Theme.Any(e => e.Themeid == id);
        }
    }
}
