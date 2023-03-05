using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreShows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MovieId", "RoomId", "StartDateTime" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 6, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "MovieId", "RoomId", "StartDateTime" },
                values: new object[,]
                {
                    { 2, 1, 1, new DateTime(2023, 3, 6, 16, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 1, 1, new DateTime(2023, 3, 6, 20, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 2, 2, new DateTime(2023, 3, 6, 13, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 2, 2, new DateTime(2023, 3, 6, 17, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 2, 2, new DateTime(2023, 3, 6, 20, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 3, 3, new DateTime(2023, 3, 6, 14, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 3, 3, new DateTime(2023, 3, 6, 18, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 3, 3, new DateTime(2023, 3, 6, 22, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 4, 4, new DateTime(2023, 3, 6, 15, 0, 0, 0, DateTimeKind.Local) },
                    { 11, 4, 4, new DateTime(2023, 3, 6, 19, 0, 0, 0, DateTimeKind.Local) },
                    { 12, 4, 4, new DateTime(2023, 3, 6, 23, 0, 0, 0, DateTimeKind.Local) },
                    { 13, 5, 5, new DateTime(2023, 3, 6, 11, 30, 0, 0, DateTimeKind.Local) },
                    { 14, 5, 5, new DateTime(2023, 3, 6, 15, 30, 0, 0, DateTimeKind.Local) },
                    { 15, 5, 5, new DateTime(2023, 3, 6, 19, 30, 0, 0, DateTimeKind.Local) },
                    { 16, 1, 1, new DateTime(2023, 3, 7, 12, 0, 0, 0, DateTimeKind.Local) },
                    { 17, 2, 2, new DateTime(2023, 3, 7, 16, 0, 0, 0, DateTimeKind.Local) },
                    { 18, 3, 3, new DateTime(2023, 3, 7, 20, 0, 0, 0, DateTimeKind.Local) },
                    { 19, 4, 4, new DateTime(2023, 3, 7, 13, 0, 0, 0, DateTimeKind.Local) },
                    { 20, 5, 5, new DateTime(2023, 3, 7, 17, 0, 0, 0, DateTimeKind.Local) },
                    { 21, 1, 1, new DateTime(2023, 3, 8, 20, 0, 0, 0, DateTimeKind.Local) },
                    { 22, 2, 2, new DateTime(2023, 3, 8, 14, 0, 0, 0, DateTimeKind.Local) },
                    { 23, 3, 3, new DateTime(2023, 3, 8, 18, 0, 0, 0, DateTimeKind.Local) },
                    { 24, 4, 4, new DateTime(2023, 3, 8, 22, 0, 0, 0, DateTimeKind.Local) },
                    { 25, 5, 5, new DateTime(2023, 3, 8, 15, 0, 0, 0, DateTimeKind.Local) },
                    { 26, 1, 1, new DateTime(2023, 3, 9, 19, 0, 0, 0, DateTimeKind.Local) },
                    { 27, 2, 2, new DateTime(2023, 3, 9, 23, 0, 0, 0, DateTimeKind.Local) },
                    { 28, 3, 3, new DateTime(2023, 3, 9, 11, 30, 0, 0, DateTimeKind.Local) },
                    { 29, 4, 4, new DateTime(2023, 3, 9, 15, 30, 0, 0, DateTimeKind.Local) },
                    { 30, 5, 5, new DateTime(2023, 3, 9, 19, 30, 0, 0, DateTimeKind.Local) },
                    { 31, 1, 1, new DateTime(2023, 3, 10, 19, 0, 0, 0, DateTimeKind.Local) },
                    { 32, 2, 2, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Local) },
                    { 33, 3, 3, new DateTime(2023, 3, 10, 11, 30, 0, 0, DateTimeKind.Local) },
                    { 34, 4, 4, new DateTime(2023, 3, 10, 15, 30, 0, 0, DateTimeKind.Local) },
                    { 35, 5, 5, new DateTime(2023, 3, 10, 19, 30, 0, 0, DateTimeKind.Local) },
                    { 36, 1, 1, new DateTime(2023, 3, 4, 19, 0, 0, 0, DateTimeKind.Local) },
                    { 37, 2, 2, new DateTime(2023, 3, 4, 23, 0, 0, 0, DateTimeKind.Local) },
                    { 38, 3, 3, new DateTime(2023, 3, 4, 11, 30, 0, 0, DateTimeKind.Local) },
                    { 39, 4, 4, new DateTime(2023, 3, 4, 15, 30, 0, 0, DateTimeKind.Local) },
                    { 40, 5, 5, new DateTime(2023, 3, 4, 19, 30, 0, 0, DateTimeKind.Local) },
                    { 41, 1, 1, new DateTime(2023, 3, 5, 19, 0, 0, 0, DateTimeKind.Local) },
                    { 42, 2, 2, new DateTime(2023, 3, 5, 23, 0, 0, 0, DateTimeKind.Local) },
                    { 43, 3, 3, new DateTime(2023, 3, 5, 11, 30, 0, 0, DateTimeKind.Local) },
                    { 44, 4, 4, new DateTime(2023, 3, 5, 15, 30, 0, 0, DateTimeKind.Local) },
                    { 45, 5, 5, new DateTime(2023, 3, 5, 19, 30, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MovieId", "RoomId", "StartDateTime" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 3, 10, 6, 27, 96, DateTimeKind.Local).AddTicks(7736) });
        }
    }
}
