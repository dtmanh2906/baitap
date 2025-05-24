using ngay24_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ngay24_5.Models;

namespace ngay24_5.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        private QLNVContext db = new QLNVContext();
        public ActionResult Index()
        {
            using (var db = new QLNVContext())
            {
                var danhSachNV = db.NhanViens.ToList();
                return View(danhSachNV);
            }
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="MaNV,TenNV,Phong,Luong")]NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                using (var db =new QLNVContext())
                {
                    if(db.NhanViens.Any(n=>n.MaNV == nhanVien.MaNV))
                    {
                        ModelState.AddModelError("MaNV", "ma nhan vien da ton tai");
                        return View(nhanVien);
                    }
                    db.NhanViens.Add(nhanVien);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
            }

            return View(nhanVien);
        }
    }
}