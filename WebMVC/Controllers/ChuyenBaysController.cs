using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ChuyenBaysController : Controller
    {
        private readonly AppDbContext _context;

        public ChuyenBaysController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ChuyenBays
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.ChuyenBay.Include(c => c.HanhKhach);
            return View(await appDbContext.ToListAsync());
        }

        // GET: ChuyenBays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ChuyenBay == null)
            {
                return NotFound();
            }

            var chuyenBay = await _context.ChuyenBay
                .Include(c => c.HanhKhach)
                .FirstOrDefaultAsync(m => m.MaChuyenBay == id);
            if (chuyenBay == null)
            {
                return NotFound();
            }

            return View(chuyenBay);
        }

        // GET: ChuyenBays/Create
        public IActionResult Create()
        {
            ViewData["MaHanhKhach"] = new SelectList(_context.HanhKhach, "MaHanhKhach", "HoTen");
            return View();
        }

        // POST: ChuyenBays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChuyenBay,MaHanhKhach,NoiDi,NoiDen,NgayBay,GiaVe")] ChuyenBay chuyenBay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuyenBay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaHanhKhach"] = new SelectList(_context.HanhKhach, "MaHanhKhach", "HoTen", chuyenBay.MaHanhKhach);
            return View(chuyenBay);
        }

        // GET: ChuyenBays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ChuyenBay == null)
            {
                return NotFound();
            }

            var chuyenBay = await _context.ChuyenBay.FindAsync(id);
            if (chuyenBay == null)
            {
                return NotFound();
            }
            ViewData["MaHanhKhach"] = new SelectList(_context.HanhKhach, "MaHanhKhach", "HoTen", chuyenBay.MaHanhKhach);
            return View(chuyenBay);
        }

        // POST: ChuyenBays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaChuyenBay,MaHanhKhach,NoiDi,NoiDen,NgayBay,GiaVe")] ChuyenBay chuyenBay)
        {
            if (id != chuyenBay.MaChuyenBay)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuyenBay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuyenBayExists(chuyenBay.MaChuyenBay))
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
            ViewData["MaHanhKhach"] = new SelectList(_context.HanhKhach, "MaHanhKhach", "HoTen", chuyenBay.MaHanhKhach);
            return View(chuyenBay);
        }

        // GET: ChuyenBays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ChuyenBay == null)
            {
                return NotFound();
            }

            var chuyenBay = await _context.ChuyenBay
                .Include(c => c.HanhKhach)
                .FirstOrDefaultAsync(m => m.MaChuyenBay == id);
            if (chuyenBay == null)
            {
                return NotFound();
            }

            return View(chuyenBay);
        }

        // POST: ChuyenBays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ChuyenBay == null)
            {
                return Problem("Entity set 'AppDbContext.ChuyenBay'  is null.");
            }
            var chuyenBay = await _context.ChuyenBay.FindAsync(id);
            if (chuyenBay != null)
            {
                _context.ChuyenBay.Remove(chuyenBay);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChuyenBayExists(int id)
        {
          return (_context.ChuyenBay?.Any(e => e.MaChuyenBay == id)).GetValueOrDefault();
        }
        // tim theo noi den
        [HttpGet]
        public IActionResult TimTheoNoiDen()
        {
            return View(new List<ChuyenBay>());
        }

        [HttpPost]
        public IActionResult TimTheoNoiDen(string noiDen)
        {
            ViewBag.NoiDen = noiDen;

            if (string.IsNullOrEmpty(noiDen))
            {
                ViewBag.ThongBao = "Vui lòng nhập nơi đến.";
                return View(new List<ChuyenBay>());
            }

            var ketQua = _context.ChuyenBay.Include(cb => cb.HanhKhach).Where(cb => cb.NoiDen.Contains(noiDen)).OrderBy(cb => cb.NgayBay).ToList();

            return View(ketQua);
        }

    }
}
