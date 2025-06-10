using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class HanhKhach
    {
        [Key]
        public int MaHanhKhach { get; set; }
        [Required, StringLength(100)]
        public string HoTen { get; set; }
        [Required, StringLength(20)]
        public string SoCMND { get; set; }
        [StringLength(0)]
        public string SoDT { get; set; }
        public ICollection<ChuyenBay>? ChuyenBays { get; set; }
    }
}
