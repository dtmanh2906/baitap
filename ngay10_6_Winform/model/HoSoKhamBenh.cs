using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngay10_6_Winform.model
{
    internal class HoSoKhamBenh
    {
        [Key]
        public int MaHoSo { get; set; }
        public int MaBenhNhan { get; set; }
        public DateTime NgayKham { get; set; }
        public string LoaiBenh { get; set; }
        public bool TinhTrangCapCuu { get; set; }
    }
}
