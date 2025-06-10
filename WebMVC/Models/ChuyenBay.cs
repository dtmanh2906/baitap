using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class ChuyenBay
    {
        [Key]
        public int MaChuyenBay { get; set; }
        [Required]
        public int MaHanhKhach { get; set; }
        [ForeignKey("MaHanhKhach")]
        public HanhKhach ? HanhKhach { get; set; }
        [Required, StringLength(100)]
        public string NoiDi { get; set; }
        [Required, StringLength(100)]
        public string NoiDen { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime NgayBay { get; set; }
        [Range(1,double.MaxValue)]
        public decimal GiaVe { get; set; }
    }
}
