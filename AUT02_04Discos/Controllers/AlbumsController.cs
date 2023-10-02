using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUT02_04Discos.Data;
using AUT02_04Discos.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AUT02_04Discos.Controllers
{
    [Authorize(Roles = "Admin, Manager, User")]
    public class AlbumsController : Controller
    {
        private readonly ChinookContext _context;

        public AlbumsController(ChinookContext context)
        {
            _context = context;
        }

        //colocar las autorizaciones 

        
        // GET: Albums
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            //añadir buscador + paginado
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentFilter"] = searchString;


            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var album = _context.Albums.Include(a => a.Artist).OrderByDescending(s => s.Title);

            if (!String.IsNullOrEmpty(searchString))
            {
                album = (IOrderedQueryable<Album>)album.Where(s => s.Title.Contains(searchString));
            }

            ViewData["CurrentFilter"] = searchString;

            //para que no de fallos el paginado
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }

            int pageSize = 15;
            return View(await paginaList<Album>.CreateAsync(album.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        
        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                //incluimos artistas y tracks
                .Include(a => a.Artist)
                .Include(b => b.Tracks)
                .FirstOrDefaultAsync(m => m.AlbumId == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        [Authorize(Roles = "Admin,Manager")]
        // GET: Albums/Create
        public IActionResult Create()
        {
            //crear el select con la información del id y que se muestre el name
            ViewData["Name"] = new SelectList(_context.Artists, "ArtistId", "Name");
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize(Roles = "Admin,Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlbumId,Title,ArtistId")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Add(album);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //crear el select con la información del id y que se muestre el name
            ViewData["Name"] = new SelectList(_context.Artists, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }

        [Authorize(Roles = "Admin,Manager")]
        // GET: Albums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var album = await _context.Albums.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            //crear el select con la información del id y que se muestre el name
            ViewData["Name"] = new SelectList(_context.Artists, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize(Roles = "Admin,Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlbumId,Title,ArtistId")] Album album)
        {
            if (id != album.AlbumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(album);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.AlbumId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            //crear el select con la información del id y que se muestre el name
            ViewData["Name"] = new SelectList(_context.Artists, "ArtistId", "Name", album.ArtistId);
            return View(album);
        }

        [Authorize(Roles = "Admin,Manager")]
        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .Include(a => a.Artist)
                .FirstOrDefaultAsync(m => m.AlbumId == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // POST: Albums/Delete/5

        [Authorize(Roles = "Admin,Manager")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Albums == null)
            {
                return Problem("Entity set 'ChinookContext.Albums'  is null.");
            }
            var album = await _context.Albums.FindAsync(id);
            if (album != null)
            {
                _context.Albums.Remove(album);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumExists(int id)
        {
          return _context.Albums.Any(e => e.AlbumId == id);
        }
    }
}
