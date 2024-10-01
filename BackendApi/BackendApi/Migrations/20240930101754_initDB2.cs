using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class initDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sponsors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sponsors",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sponsors",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "Products",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Products",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Person",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Person",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentStatus",
                table: "Payments",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Payments",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Payments",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Payments",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "PaymentLog",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(6)");

            migrationBuilder.AlterColumn<string>(
                name: "zipcode",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdmin",
                table: "Customers",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(ulong),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "Contacts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contacts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentType",
                table: "ApprovalPayment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentId",
                table: "ApprovalPayment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentDescription",
                table: "ApprovalPayment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentCode",
                table: "ApprovalPayment",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8023), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8059), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8062), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8064), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8065), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8067), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8069), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8071), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8073), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8075), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8076), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8078), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8080), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8082), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8084), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8086), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8087), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8089), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8092), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8093), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8095), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8097), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8099), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8101), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8103), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8105), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8107), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8108), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8110), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8112), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8114), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8116), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8117), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8119), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8121), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8123), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8125), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8127), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8129), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8131), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8132), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8134), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8136), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8138), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8140), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8142), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8143), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8145), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8147), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8149), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8151), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8152), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8154), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8156), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8158), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8160), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8162), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8164), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8165), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8167), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8169), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8171), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8172), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8174), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8176), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8178), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8180), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8181), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8183), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8185), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8187), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8189), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8191), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8193), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8215), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8217), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8220), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8222), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8224), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8226), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8228), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8230), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8235), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8237), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8239), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8240), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8243), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8244), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8246), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8248), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8250), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8252), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8253), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8255), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8257), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8259), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8260), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8262), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8264), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 17, 54, 241, DateTimeKind.Local).AddTicks(8266), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sponsors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sponsors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Sponsors",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<ulong>(
                name: "IsAvailable",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Products",
                type: "datetime2(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentStatus",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "PaymentLog",
                type: "datetime2(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "zipcode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<ulong>(
                name: "IsAdmin",
                table: "Customers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentType",
                table: "ApprovalPayment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentId",
                table: "ApprovalPayment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentDescription",
                table: "ApprovalPayment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentCode",
                table: "ApprovalPayment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4774), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4809), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4811), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4813), 0ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4815), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4816), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4818), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4820), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4823), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4824), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4826), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4828), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4830), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4831), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4833), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4869), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4871), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4873), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4875), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4877), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4878), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4880), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4882), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4884), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4885), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4887), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4890), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4892), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4894), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4896), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4898), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4900), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4901), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4903), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4905), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4907), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4909), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4911), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4912), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4914), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4916), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4918), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4919), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4921), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4923), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4925), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4927), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4929), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4930), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4932), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4934), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4936), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4937), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4939), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4941), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4943), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4944), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4946), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4948), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4950), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4951), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4957), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4959), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4961), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4962), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4964), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4966), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4968), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4969), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4971), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4973), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4975), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4977), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4978), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4980), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4982), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4984), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4985), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4987), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4989), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4991), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4993), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4995), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4997), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(4998), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5000), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5002), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5003), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5005), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5007), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5009), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5010), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5012), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5014), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5016), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5018), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5020), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5021), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5023), 1ul });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateTime", "IsAvailable" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 14, 29, 420, DateTimeKind.Local).AddTicks(5025), 1ul });
        }
    }
}
