using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedDemoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MovieId", "RoomId", "StartDateTime" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 20, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MovieId", "RoomId", "StartDateTime" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 20, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 20, 20, 0, 0, 0, DateTimeKind.Local), "IMAX" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MovieId", "StartDateTime", "Type" },
                values: new object[] { 2, new DateTime(2023, 3, 20, 13, 0, 0, 0, DateTimeKind.Local), "2D" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MovieId", "StartDateTime", "Type" },
                values: new object[] { 2, new DateTime(2023, 3, 20, 17, 0, 0, 0, DateTimeKind.Local), "3D-HFR" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[,]
                {
                    { 6, 2, 2, new DateTime(2023, 3, 20, 20, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 7, 3, 3, new DateTime(2023, 3, 20, 14, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 8, 3, 3, new DateTime(2023, 3, 20, 18, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 9, 3, 3, new DateTime(2023, 3, 20, 22, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 10, 4, 4, new DateTime(2023, 3, 20, 15, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 11, 4, 4, new DateTime(2023, 3, 20, 19, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 12, 4, 4, new DateTime(2023, 3, 20, 23, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 13, 5, 5, new DateTime(2023, 3, 20, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 14, 5, 5, new DateTime(2023, 3, 20, 15, 30, 0, 0, DateTimeKind.Local), "3D" },
                    { 15, 5, 5, new DateTime(2023, 3, 20, 19, 30, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 16, 1, 1, new DateTime(2023, 3, 21, 12, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 17, 2, 2, new DateTime(2023, 3, 21, 16, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 18, 3, 3, new DateTime(2023, 3, 21, 20, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 19, 4, 4, new DateTime(2023, 3, 21, 13, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 20, 5, 5, new DateTime(2023, 3, 21, 17, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 21, 1, 1, new DateTime(2023, 3, 22, 20, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 22, 2, 2, new DateTime(2023, 3, 22, 14, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 23, 3, 3, new DateTime(2023, 3, 22, 18, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 24, 4, 4, new DateTime(2023, 3, 22, 22, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 25, 5, 5, new DateTime(2023, 3, 22, 15, 0, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 26, 1, 1, new DateTime(2023, 3, 16, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 27, 2, 2, new DateTime(2023, 3, 16, 23, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 28, 3, 3, new DateTime(2023, 3, 16, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 29, 4, 4, new DateTime(2023, 3, 16, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 30, 5, 5, new DateTime(2023, 3, 16, 19, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 31, 1, 1, new DateTime(2023, 3, 17, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 32, 2, 2, new DateTime(2023, 3, 17, 23, 0, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 33, 3, 3, new DateTime(2023, 3, 17, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 34, 4, 4, new DateTime(2023, 3, 17, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 35, 5, 5, new DateTime(2023, 3, 17, 19, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 36, 1, 1, new DateTime(2023, 3, 18, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 37, 2, 2, new DateTime(2023, 3, 18, 23, 0, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 38, 3, 3, new DateTime(2023, 3, 18, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 39, 4, 4, new DateTime(2023, 3, 18, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 40, 5, 5, new DateTime(2023, 3, 18, 19, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 41, 1, 1, new DateTime(2023, 3, 19, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 42, 2, 2, new DateTime(2023, 3, 19, 23, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 43, 3, 3, new DateTime(2023, 3, 19, 11, 30, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 44, 4, 4, new DateTime(2023, 3, 19, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 45, 5, 5, new DateTime(2023, 3, 19, 19, 30, 0, 0, DateTimeKind.Local), "2D" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 3, 2, new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MovieId", "RoomId", "StartDateTime" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6324), "3D-HFR" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MovieId", "StartDateTime", "Type" },
                values: new object[] { 3, new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6332), "IMAX" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MovieId", "StartDateTime", "Type" },
                values: new object[] { 3, new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6340), "2D" });
        }
    }
}
