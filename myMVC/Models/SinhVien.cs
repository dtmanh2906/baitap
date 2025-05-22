using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myMVC.Models
{
    public class SinhVien
    {
        [Key]
        
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public double Diem { get; set; }
    }
}
