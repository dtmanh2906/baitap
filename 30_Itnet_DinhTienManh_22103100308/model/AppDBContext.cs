using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _30_Itnet_DinhTienManh_22103100308.model
{
    internal class AppDBContext : DbContext
    {
        public DbSet<PhongThucHanh> PhongThucHanhs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=QLPhongThucHanh;Integrated Security=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhongThucHanh>().HasData(
                new PhongThucHanh
                {
                    MaPhong = "P01",
                    TenPhong = "phong A",
                    SucChua = 40,
                    CoMayChieu = true,
                    NgayDuaVaoSuDung = new DateTime(2022, 1, 1)
                },
                new PhongThucHanh
                {
                    MaPhong="P02",
                    TenPhong="Phong B",
                    SucChua=50,
                    CoMayChieu=false,
                    NgayDuaVaoSuDung=new DateTime(2021,5,15)
                } ,
                new PhongThucHanh
                {
                    MaPhong = "P003",
                    TenPhong = "Phòng C",
                    SucChua = 50,
                    CoMayChieu = true,
                    NgayDuaVaoSuDung = new DateTime(2020, 9, 10)
                }
             );


        }
    }
}
