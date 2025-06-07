using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _30_Itnet_DinhTienManh_22103100308.Migrations
{
    public partial class dinhtienmanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongThucHanhs",
                columns: table => new
                {
                    MaPhong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucChua = table.Column<int>(type: "int", nullable: false),
                    CoMayChieu = table.Column<bool>(type: "bit", nullable: false),
                    NgayDuaVaoSuDung = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongThucHanhs", x => x.MaPhong);
                });

            migrationBuilder.InsertData(
                table: "PhongThucHanhs",
                columns: new[] { "MaPhong", "CoMayChieu", "NgayDuaVaoSuDung", "SucChua", "TenPhong" },
                values: new object[] { "P003", true, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Phòng C" });

            migrationBuilder.InsertData(
                table: "PhongThucHanhs",
                columns: new[] { "MaPhong", "CoMayChieu", "NgayDuaVaoSuDung", "SucChua", "TenPhong" },
                values: new object[] { "P01", true, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "phong A" });

            migrationBuilder.InsertData(
                table: "PhongThucHanhs",
                columns: new[] { "MaPhong", "CoMayChieu", "NgayDuaVaoSuDung", "SucChua", "TenPhong" },
                values: new object[] { "P02", false, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Phong B" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhongThucHanhs");
        }
    }
}
