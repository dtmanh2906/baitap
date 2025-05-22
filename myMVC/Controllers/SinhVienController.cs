using Microsoft.AspNetCore.Mvc;
using myMVC.Models;
using QLSV_Core.Models;

namespace myMVC.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly QLSVContext _context;

        public SinhVienController(QLSVContext context)
        {
            _context = context;
        }

        // GET: Hiển thị form thêm sinh viên
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nhận dữ liệu từ form để lưu vào database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MaSV,HoTen,Lop,Diem")] SinhVien sinhVien)  // 🛑 Thêm MaSV vào Bind
        {
            if (_context.SinhVien.Any(s => s.MaSV == sinhVien.MaSV))  // 🛑 Kiểm tra nếu MaSV đã tồn tại
            {
                ModelState.AddModelError("MaSV", "Mã sinh viên đã tồn tại!");
                return View(sinhVien);
            }

            if (ModelState.IsValid)
            {
                _context.SinhVien.Add(sinhVien);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(sinhVien);
        }

        // GET: Hiển thị form sửa sinh viên
        public IActionResult Edit(int id)
        {
            var sinhVien = _context.SinhVien.Find(id);
            if (sinhVien == null) return NotFound();
            return View(sinhVien);
        }

        // POST: Nhận dữ liệu và cập nhật database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sinhVien);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(sinhVien);
        }
        // GET: Hiển thị form xác nhận xóa
        public IActionResult Delete(int id)
        {
            var sinhVien = _context.SinhVien.Find(id);
            if (sinhVien == null) return NotFound();
            return View(sinhVien);
        }

        // POST: Xóa sinh viên khỏi database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var sinhVien = _context.SinhVien.Find(id);
            if (sinhVien != null)
            {
                _context.SinhVien.Remove(sinhVien);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        //tìm kiếm
        public IActionResult Index(int? searchMaSV)
        {
            var sinhViens = _context.SinhVien.AsQueryable();

            if (searchMaSV.HasValue) // 🛑 Nếu có mã sinh viên cần tìm
            {
                sinhViens = sinhViens.Where(s => s.MaSV == searchMaSV);
            }

            return View(sinhViens.ToList());
        }



    }

}
