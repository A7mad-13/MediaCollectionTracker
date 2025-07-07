using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediaCollectionTracker.Data;
using MediaCollectionTracker.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollectionTracker.Controllers
{
    public class MediaItemsController : Controller
    {
        private readonly MediaContext _context;

        public MediaItemsController(MediaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var items = from m in _context.MediaItems select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(m => m.Title.Contains(searchString) ||
                                         m.Creator.Contains(searchString) ||
                                         m.Genre.Contains(searchString));
            }

            return View(await items.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Creator,ReleaseDate,Genre,MediaType,Status")] MediaItem mediaItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mediaItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mediaItem);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var mediaItem = await _context.MediaItems.FindAsync(id);
            if (mediaItem == null) return NotFound();
            return View(mediaItem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Creator,ReleaseDate,Genre,MediaType,Status")] MediaItem mediaItem)
        {
            if (id != mediaItem.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(mediaItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mediaItem);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var mediaItem = await _context.MediaItems.FindAsync(id);
            if (mediaItem == null) return NotFound();
            return View(mediaItem);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mediaItem = await _context.MediaItems.FindAsync(id);
            _context.MediaItems.Remove(mediaItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}