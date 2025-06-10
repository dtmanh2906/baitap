using WebMVC.Models;

namespace WebMVC.ViewModel
{
    public class ThongKeKhachHangViewModel
    {
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public decimal TongTien { get; set; }
        public List<ChuyenBay> DanhSachChuyenBay { get; set; }
    }
}
