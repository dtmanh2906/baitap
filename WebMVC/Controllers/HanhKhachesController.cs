using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models;
using WebMVC.ViewModel;

namespace WebMVC.Controllers
{
    public class HanhKhachesController : Controller
    {
        private readonly AppDbContext _context;

        public HanhKhachesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: HanhKhaches
        public async Task<IActionResult> Index()
        {
              return _context.HanhKhach != null ? 
                          View(await _context.HanhKhach.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.HanhKhach'  is null.");
        }

        // GET: HanhKhaches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HanhKhach == null)
            {
                return NotFound();
            }

            var hanhKhach = await _context.HanhKhach
                .FirstOrDefaultAsync(m => m.MaHanhKhach == id);
            if (hanhKhach == null)
            {
                return NotFound();
            }

            return View(hanhKhach);
        }

        // GET: HanhKhaches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HanhKhaches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHanhKhach,HoTen,SoCMND,SoDT")] HanhKhach hanhKhach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hanhKhach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hanhKhach);
        }

        // GET: HanhKhaches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HanhKhach == null)
            {
                return NotFound();
            }

            var hanhKhach = await _context.HanhKhach.FindAsync(id);
            if (hanhKhach == null)
            {
                return NotFound();
            }
            return View(hanhKhach);
        }

        // POST: HanhKhaches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHanhKhach,HoTen,SoCMND,SoDT")] HanhKhach hanhKhach)
        {
            if (id != hanhKhach.MaHanhKhach)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hanhKhach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HanhKhachExists(hanhKhach.MaHanhKhach))
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
            return View(hanhKhach);
        }

        // GET: HanhKhaches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HanhKhach == null)
            {
                return NotFound();
            }

            var hanhKhach = await _context.HanhKhach
                .FirstOrDefaultAsync(m => m.MaHanhKhach == id);
            if (hanhKhach == null)
            {
                return NotFound();
            }

            return View(hanhKhach);
        }

        // POST: HanhKhaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HanhKhach == null)
            {
                return Problem("Entity set 'AppDbContext.HanhKhach'  is null.");
            }
            var hanhKhach = await _context.HanhKhach.FindAsync(id);
            if (hanhKhach != null)
            {
                _context.HanhKhach.Remove(hanhKhach);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HanhKhachExists(int id)
        {
          return (_context.HanhKhach?.Any(e => e.MaHanhKhach == id)).GetValueOrDefault();
        }
        //thống kê chuyến bay lớn hơn 200000000
        public IActionResult ThongKeHanhKhach()
        {
            var danhSach = _context.HanhKhach
                .Select(hk => new
                {
                    HanhKhach = hk,
                    ChuyenBays = _context.ChuyenBay.Where(cb => cb.MaHanhKhach == hk.MaHanhKhach).ToList()
                })
                .AsEnumerable() // Đưa về xử lý LINQ to Objects
                .Select(x => new ThongKeKhachHangViewModel
                {
                    HoTen = x.HanhKhach.HoTen,
                    SoCMND = x.HanhKhach.SoCMND,
                    TongTien = x.ChuyenBays.Sum(cb => cb.GiaVe),
                    DanhSachChuyenBay = x.ChuyenBays
                })
                .Where(x => x.TongTien >= 20000000) // Lọc >= 20 triệu
                .ToList();

            return View(danhSach);
        }

    }
}
