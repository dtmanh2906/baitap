using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _30_Itnet_DinhTienManh_22103100308.model
{
    internal class PhongThucHanh
    {
        [Key]
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int SucChua { get; set; }
        public bool CoMayChieu { get; set; }
        public DateTime NgayDuaVaoSuDung { get; set; }
    }
}
