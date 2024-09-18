using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class AddMoneyTableToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Spend",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 26, 33, 302, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 26, 33, 302, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 26, 33, 302, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 26, 33, 302, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 26, 33, 302, DateTimeKind.Local).AddTicks(3645));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spend",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 0, 25, 738, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 0, 25, 738, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 0, 25, 738, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 0, 25, 738, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 9, 18, 10, 0, 25, 738, DateTimeKind.Local).AddTicks(6364));
        }
    }
}
