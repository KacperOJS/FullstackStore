using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class DodanyContactController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateTime",
                value: new DateTime(2024, 9, 24, 13, 34, 58, 330, DateTimeKind.Local).AddTicks(5432));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6490));
        }
    }
}
