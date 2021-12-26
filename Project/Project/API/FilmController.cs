using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API
{
    namespace WebFilm.API
    {
        [Route("api/[controller]")]
        [ApiController]
        public class FilmController : Controller
        {
            private readonly Context _context;
            public FilmController(Context context)
            {
                _context = context;
            }
            //api/film
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Film>>> GetFilm()
            {
                return await _context.Film.ToListAsync();
            }
            // GET: api/Film/1
            [HttpGet("{id}")]
            public async Task<ActionResult<Film>> GetFilm(int id)
            {
                var Film = await _context.Film.FindAsync(id);

                if (Film == null)
                {
                    return NotFound();
                }

                return Film;
            }
            // PUT: api/Film/1
            [HttpPut("{id}")]
            public async Task<IActionResult> PutFilm(int id, Film Film)
            {
                if (id != Film.FilmID)
                {
                    return BadRequest();
                }

                _context.Entry(Film).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(id))
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
            // POST: api/Film
            [HttpPost]
            public async Task<ActionResult<Film>> PostFilm(Film Film)
            {
                _context.Film.Add(Film);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetFilm", new { id = Film.FilmID }, Film);
            }
            // DELETE: api/Film/1
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteFilm(int id)
            {
                var Film = await _context.Film.FindAsync(id);
                if (Film == null)
                {
                    return NotFound();
                }

                _context.Film.Remove(Film);
                await _context.SaveChangesAsync();

                return NoContent();
            }


            public IActionResult Index()
            {
                return View();
            }
            private bool FilmExists(int id)
            {
                return _context.Film.Any(e => e.FilmID == id);
            }
        }
    }
   
}
