using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngay10_6_Winform.model
{
    internal class DataContext : DbContext
    {
        public DbSet<HoSoKhamBenh> HoSoKhamBenhs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = localhost\MSSQLSERVER01; Initial Catalog = HoSoKhamBenh; Integrated Security = True; Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HoSoKhamBenh>().HasData(
                new HoSoKhamBenh { MaHoSo = 1, MaBenhNhan = 1, NgayKham = new DateTime(2025, 6, 6), LoaiBenh = "sot", TinhTrangCapCuu = false },
                new HoSoKhamBenh { MaHoSo = 2, MaBenhNhan = 2, NgayKham = new DateTime(2025, 3, 6), LoaiBenh = "sot", TinhTrangCapCuu = false },
                new HoSoKhamBenh { MaHoSo = 3, MaBenhNhan = 3, NgayKham = new DateTime(2025, 4, 6), LoaiBenh = "sot", TinhTrangCapCuu = false }
                );
        }
    }
}
