using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC.Migrations
{
    public partial class dinhtienmanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HanhKhach",
                columns: table => new
                {
                    MaHanhKhach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoCMND = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HanhKhach", x => x.MaHanhKhach);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenBay",
                columns: table => new
                {
                    MaChuyenBay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHanhKhach = table.Column<int>(type: "int", nullable: false),
                    NoiDi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NoiDen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayBay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiaVe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenBay", x => x.MaChuyenBay);
                    table.ForeignKey(
                        name: "FK_ChuyenBay_HanhKhach_MaHanhKhach",
                        column: x => x.MaHanhKhach,
                        principalTable: "HanhKhach",
                        principalColumn: "MaHanhKhach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HanhKhach",
                columns: new[] { "MaHanhKhach", "HoTen", "SoCMND", "SoDT" },
                values: new object[] { 1, "Nguyen Van A", "123456789", "0123456789" });

            migrationBuilder.InsertData(
                table: "HanhKhach",
                columns: new[] { "MaHanhKhach", "HoTen", "SoCMND", "SoDT" },
                values: new object[] { 2, "Nguyen Van B", "389414794", "3741479174" });

            migrationBuilder.InsertData(
                table: "HanhKhach",
                columns: new[] { "MaHanhKhach", "HoTen", "SoCMND", "SoDT" },
                values: new object[] { 3, "Nguyen Van c", "374914147", "3417369746" });

            migrationBuilder.InsertData(
                table: "ChuyenBay",
                columns: new[] { "MaChuyenBay", "GiaVe", "MaHanhKhach", "NgayBay", "NoiDen", "NoiDi" },
                values: new object[] { 1, 1500000m, 1, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ha Noi", "Phu Tho" });

            migrationBuilder.InsertData(
                table: "ChuyenBay",
                columns: new[] { "MaChuyenBay", "GiaVe", "MaHanhKhach", "NgayBay", "NoiDen", "NoiDi" },
                values: new object[] { 2, 15000000m, 1, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quang Ninh", "Ha Noi" });

            migrationBuilder.InsertData(
                table: "ChuyenBay",
                columns: new[] { "MaChuyenBay", "GiaVe", "MaHanhKhach", "NgayBay", "NoiDen", "NoiDi" },
                values: new object[] { 3, 21000000m, 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sa Pa", "Ha Noi" });

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_MaHanhKhach",
                table: "ChuyenBay",
                column: "MaHanhKhach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuyenBay");

            migrationBuilder.DropTable(
                name: "HanhKhach");
        }
    }
}
