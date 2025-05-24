using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ngay24_5.Models
{
	public class NhanVien
	{
		[Key]
		public string MaNV { get; set; }
		public string TenNV { get; set; }
		public string Phong { get; set; }
		public float Luong { get; set; }
	}
}