using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLog_Customers_Customerid",
                table: "PaymentLog");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLog_Customers_Customerid",
                table: "PaymentLog",
                column: "Customerid",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentLog_Customers_Customerid",
                table: "PaymentLog");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentLog_Customers_Customerid",
                table: "PaymentLog",
                column: "Customerid",
                principalTable: "Customers",
                principalColumn: "id");
        }
    }
}
