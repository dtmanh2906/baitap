using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ngay10_6_Winform.Migrations
{
    public partial class dintienmanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoSoKhamBenhs",
                columns: table => new
                {
                    MaHoSo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaBenhNhan = table.Column<int>(type: "int", nullable: false),
                    NgayKham = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoaiBenh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhTrangCapCuu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoKhamBenhs", x => x.MaHoSo);
                });

            migrationBuilder.InsertData(
                table: "HoSoKhamBenhs",
                columns: new[] { "MaHoSo", "LoaiBenh", "MaBenhNhan", "NgayKham", "TinhTrangCapCuu" },
                values: new object[] { 1, "sot", 1, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "HoSoKhamBenhs",
                columns: new[] { "MaHoSo", "LoaiBenh", "MaBenhNhan", "NgayKham", "TinhTrangCapCuu" },
                values: new object[] { 2, "sot", 2, new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "HoSoKhamBenhs",
                columns: new[] { "MaHoSo", "LoaiBenh", "MaBenhNhan", "NgayKham", "TinhTrangCapCuu" },
                values: new object[] { 3, "sot", 3, new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoSoKhamBenhs");
        }
    }
}
