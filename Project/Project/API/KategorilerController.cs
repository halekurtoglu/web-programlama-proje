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
        public class KategorilerController : Controller
        {
            private readonly Context _context;
            public KategorilerController(Context context)
            {
                _context = context;
            }
            //api/film
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Kategori>>> GetKategori()
            {
                return await _context.Kategori.ToListAsync();
            }
            //api/Film/1
            [HttpGet("{id}")]
            public async Task<ActionResult<Kategori>> GetKategori(int id)
            {
                var Kategori = await _context.Kategori.FindAsync(id);

                if (Kategori == null)
                {
                    return NotFound();
                }

                return Kategori;
            }
            //api/Film/1
            [HttpPut("{id}")]
            public async Task<IActionResult> PutKategori(int id, Kategori Kategori)
            {
                if (id != Kategori.KategoriID)
                {
                    return BadRequest();
                }

                _context.Entry(Kategori).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KategoriExists(id))
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
            //api/Film
            [HttpPost]
            public async Task<ActionResult<Kategori>> PostKategori(Kategori Kategori)
            {
                _context.Kategori.Add(Kategori);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetKategori", new { id = Kategori.KategoriID }, Kategori);
            }
            //api/Film/1
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteKategori(int id)
            {
                var Kategori = await _context.Kategori.FindAsync(id);
                if (Kategori == null)
                {
                    return NotFound();
                }

                _context.Kategori.Remove(Kategori);
                await _context.SaveChangesAsync();

                return NoContent();
            }


            public IActionResult Index()
            {
                return View();
            }
            private bool KategoriExists(int id)
            {
                return _context.Kategori.Any(e => e.KategoriID == id);
            }
        }
    }
   
}
