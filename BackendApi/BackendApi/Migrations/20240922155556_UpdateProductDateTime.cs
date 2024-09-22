using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateTime", "Description", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6302), "High-performance gaming PC with the latest GPU.", true, "Gaming PC", 1999 },
                    { 7, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6304), "27-inch 144Hz gaming monitor for smooth gameplay.", true, "Gaming Monitor", 349 },
                    { 8, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6305), "RGB mechanical keyboard with customizable keys.", true, "Mechanical Keyboard", 129 },
                    { 9, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6307), "High-precision gaming mouse with adjustable DPI.", true, "Gaming Mouse", 59 },
                    { 10, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6309), "Top-of-the-line graphics card for gaming.", true, "Graphics Card", 499 },
                    { 11, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6311), "High-performance CPU for gaming and multitasking.", true, "Processor", 299 },
                    { 12, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6312), "Gaming motherboard with RGB lighting and advanced features.", true, "Motherboard", 199 },
                    { 13, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6314), "Ergonomic gaming chair for long hours of play.", true, "Gaming Chair", 249 },
                    { 14, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6316), "1TB SSD for faster load times in games.", true, "SSD 1TB", 129 },
                    { 15, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6318), "2TB HDD for additional storage.", true, "HDD 2TB", 69 },
                    { 16, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6319), "Immersive VR headset for gaming.", true, "VR Headset", 399 },
                    { 17, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6321), "Latest generation game console.", true, "Game Console", 499 },
                    { 18, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6323), "Wireless controller for gaming consoles.", true, "Controller", 59 },
                    { 19, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6325), "Spacious desk designed for gaming setups.", true, "Gaming Desk", 199 },
                    { 20, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6327), "High-definition webcam for streaming.", true, "Webcam", 89 },
                    { 21, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6328), "USB microphone for clear audio during streams.", true, "Microphone", 129 },
                    { 22, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6330), "Capture card for streaming console gameplay.", true, "Capture Card", 149 },
                    { 23, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6332), "Blue light blocking glasses for gamers.", true, "Gaming Glasses", 39 },
                    { 24, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6333), "Monthly subscription for access to a library of games.", true, "Game Subscription", 59 },
                    { 25, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6335), "Gift card for purchasing games online.", true, "Game Gift Card", 50 },
                    { 26, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6337), "High-speed router optimized for gaming.", true, "Gaming Router", 99 },
                    { 27, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6339), "500GB portable SSD for on-the-go gaming.", true, "Portable SSD 500GB", 79 },
                    { 28, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6340), "Stereo headset with built-in microphone.", true, "Gaming Headset", 99 },
                    { 29, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6342), "Versatile gamepad for various consoles.", true, "Gamepad", 49 },
                    { 30, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6344), "Large RGB mouse pad for gaming.", true, "RGB Mouse Pad", 29 },
                    { 31, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6346), "Storage solution for game discs and accessories.", true, "Game Storage Box", 19 },
                    { 32, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6347), "Cooling pad for laptops during long gaming sessions.", true, "Gaming Cooling Pad", 39 },
                    { 33, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6349), "VR games for immersive experiences.", true, "Virtual Reality Games", 39 },
                    { 34, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6351), "Compact pouch for gaming accessories.", true, "Gaming Pouch", 15 },
                    { 35, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6353), "Software for creating your own games.", true, "Game Development Software", 299 },
                    { 36, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6355), "Art book featuring designs from popular games.", true, "Game Art Book", 25 },
                    { 37, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6357), "Comprehensive strategy guide for popular games.", true, "Gaming Strategy Guide", 20 },
                    { 38, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6358), "Comfortable t-shirt for gamers.", true, "Gaming T-shirt", 24 },
                    { 39, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6360), "Warm hoodie for gamers.", true, "Gaming Hoodie", 49 },
                    { 40, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6362), "Figures from popular game franchises.", true, "Collectible Figurines", 34 },
                    { 41, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6363), "Cable management solution for gaming mice.", true, "Gaming Mouse Bungee", 19 },
                    { 42, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6365), "Stand for organizing gaming consoles.", true, "Console Stand", 29 },
                    { 43, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6367), "Holds multiple game cards securely.", true, "Game Card Holder", 15 },
                    { 44, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6368), "Protective mat for gaming chairs.", true, "Gaming Chair Mat", 39 },
                    { 45, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6370), "Lighting for enhancing streaming quality.", true, "Streaming Light", 59 },
                    { 46, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6372), "Posters and wall art for gamers.", true, "Game Theme Wall Art", 49 },
                    { 47, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6374), "Portable monitor for gaming on the go.", true, "Portable Gaming Monitor", 299 },
                    { 48, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6375), "Gift card for purchasing games on Steam.", true, "Steam Gift Card", 50 },
                    { 49, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6377), "Gift card for purchasing games on Epic Games Store.", true, "Epic Games Gift Card", 50 },
                    { 50, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6379), "Monthly subscription box for gaming goodies.", true, "Gaming Subscription Box", 39 },
                    { 51, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6381), "Full-sized arcade machine for home use.", true, "Arcade Machine", 999 },
                    { 52, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6382), "Everything you need for a gaming LAN party.", true, "Gaming LAN Party Kit", 199 },
                    { 53, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6384), "Guide to building the ultimate gaming setup.", true, "Pro Gaming Setup Guide", 29 },
                    { 54, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6386), "Complete setup for game streaming.", true, "Game Streaming Setup", 399 },
                    { 55, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6388), "Books about gaming culture.", true, "Gaming Lifestyle Book", 20 },
                    { 56, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6389), "Console with classic games from the past.", true, "Retro Gaming Console", 149 },
                    { 57, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6391), "Jewelry for gamers.", true, "Gaming Jewelry", 24 },
                    { 58, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6393), "Costumes based on popular game characters.", true, "Game Character Costume", 89 },
                    { 59, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6395), "Join a community of gamers.", true, "Gaming Community Membership", 19 },
                    { 60, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6396), "Controller for mobile gaming.", true, "Mobile Gaming Controller", 39 },
                    { 61, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6398), "Get a custom-built gaming PC.", true, "Custom PC Building Service", 199 },
                    { 62, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6400), "Comfortable socks with game themes.", true, "Game Themed Socks", 15 },
                    { 63, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6402), "Access to various games for a monthly fee.", true, "Gaming Subscription Service", 49 },
                    { 64, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6404), "Your personal arcade at home.", true, "Home Arcade Cabinet", 899 },
                    { 65, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6405), "Learn how to stream games effectively.", true, "Game Streaming Course", 99 },
                    { 66, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6430), "Vinyl records of popular game soundtracks.", true, "Game Soundtrack Vinyl", 29 },
                    { 67, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6433), "Glasses for enhanced 3D gaming experience.", true, "3D Gaming Glasses", 49 },
                    { 68, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6434), "Portable console for gaming on the go.", true, "Gaming Handheld Console", 199 },
                    { 69, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6436), "Recipes inspired by popular games.", true, "Gamer's Cookbook", 25 },
                    { 70, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6438), "Card for purchasing in-game currency.", true, "In-Game Currency Card", 20 },
                    { 71, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6440), "Pass for online gaming access.", true, "Online Game Pass", 29 },
                    { 72, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6442), "Workout gear designed for gamers.", true, "Gaming Workout Gear", 45 },
                    { 73, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6444), "Learn how to design your own games.", true, "Game Design Course", 199 },
                    { 74, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6446), "Art prints from popular games.", true, "Game Art Prints", 29 },
                    { 75, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6447), "Stay updated with the latest gaming news.", true, "Gaming News Subscription", 19 },
                    { 76, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6449), "Tools for aspiring game developers.", true, "Game Development Toolkit", 89 },
                    { 77, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6451), "Tickets for major e-sports events.", true, "E-sports Event Tickets", 100 },
                    { 78, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6453), "Cushion for added comfort in gaming chairs.", true, "Gaming Chair Cushion", 19 },
                    { 79, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6454), "Software for remaking classic games.", true, "Game Remake Software", 199 },
                    { 80, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6456), "Book filled with gaming challenges to try.", true, "Gaming Challenge Book", 24 },
                    { 81, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6458), "Organize your gaming accessories and gear.", true, "Gamer's Desk Organizer", 35 },
                    { 82, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6459), "Stress ball for gamers.", true, "Gaming Stress Ball", 10 },
                    { 83, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6461), "Protective skin for game controllers.", true, "Game Controller Skin", 15 },
                    { 84, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6463), "All you need for a perfect game night.", true, "Game Night Kit", 29 },
                    { 85, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6465), "Art installation based on video games.", true, "Video Game Art Installation", 999 },
                    { 86, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6466), "Learn how to market your games effectively.", true, "Game Marketing Course", 99 },
                    { 87, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6468), "Get a professional trailer for your game.", true, "Game Trailer Production", 299 },
                    { 88, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6470), "One-on-one coaching for competitive gaming.", true, "Esports Coaching", 150 },
                    { 89, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6472), "Bag designed for transporting gaming gear.", true, "Gaming Travel Bag", 49 },
                    { 90, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6473), "Learn to develop games for mobile devices.", true, "Mobile Game Development Course", 199 },
                    { 91, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6475), "Guide to help gamers relax and focus.", true, "Gamer's Meditation Guide", 19 },
                    { 92, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6477), "Merchandise from popular game franchises.", true, "Game Merchandise", 29 },
                    { 93, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6478), "Tools and resources for training in e-sports.", true, "E-sports Training Kit", 199 },
                    { 94, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6480), "Access to exclusive gaming community forums.", true, "Gaming Community Forum Access", 10 },
                    { 95, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6482), "Software for designing video games.", true, "Game Design Software", 299 },
                    { 96, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6483), "CD of music from popular games.", true, "Game Soundtrack CD", 19 },
                    { 97, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6485), "Cooling pad designed for gaming laptops.", true, "Gaming Laptop Cooling Pad", 49 },
                    { 98, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6487), "Service for playtesting your game.", true, "Game Playtesting Service", 99 },
                    { 99, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6489), "Stay updated on gaming culture and trends.", true, "Gaming Culture Magazine Subscription", 29 },
                    { 100, new DateTime(2024, 9, 22, 17, 55, 56, 399, DateTimeKind.Local).AddTicks(6490), "A retreat focused on gamer wellness and community.", true, "Gamer's Wellness Retreat", 999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

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
        }
    }
}
