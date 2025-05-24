		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Web;
		using System.Data.Entity;

		namespace ngay24_5.Models
		{
			public class QLNVContext :DbContext
			{
				public QLNVContext() : base("name=QLNVContext") { }
				public DbSet<NhanVien> NhanViens{ get; set; }
			}
		}