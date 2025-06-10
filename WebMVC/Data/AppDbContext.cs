using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<HanhKhach>().HasData(
            new HanhKhach { MaHanhKhach = 01, HoTen = "Nguyen Van A", SoCMND = "123456789", SoDT = "0123456789" },
            new HanhKhach { MaHanhKhach = 02, HoTen = "Nguyen Van B", SoCMND = "389414794", SoDT = "3741479174" },
            new HanhKhach { MaHanhKhach = 03, HoTen = "Nguyen Van c", SoCMND = "374914147", SoDT = "3417369746" }
            );
        modelBuilder.Entity<ChuyenBay>().HasData(
            new ChuyenBay { MaChuyenBay = 01, MaHanhKhach = 01, NoiDi = "Phu Tho", NoiDen = "Ha Noi", NgayBay = new DateTime(2025, 6, 20), GiaVe = 1500000 },
            new ChuyenBay { MaChuyenBay = 02, MaHanhKhach = 01, NoiDi = "Ha Noi", NoiDen = "Quang Ninh", NgayBay = new DateTime(2025, 6, 15), GiaVe = 15000000 },
            new ChuyenBay { MaChuyenBay = 03, MaHanhKhach = 02, NoiDi = "Ha Noi", NoiDen = "Sa Pa", NgayBay = new DateTime(2025, 6, 10), GiaVe = 21000000 }
            );
    }

    public DbSet<WebMVC.Models.HanhKhach> HanhKhach { get; set; } = default!;

    public DbSet<WebMVC.Models.ChuyenBay>? ChuyenBay { get; set; }
}
