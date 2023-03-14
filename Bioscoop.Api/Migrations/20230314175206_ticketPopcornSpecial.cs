using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class ticketPopcornSpecial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Popcorn",
                table: "Tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Special",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5136), "2D" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5183), "3D" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5192), "3D-HFR" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MovieId", "StartDateTime", "Type" },
                values: new object[] { 3, new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5200), "IMAX" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 5, 3, 2, new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5207), "2D" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Popcorn", "Special" },
                values: new object[] { false, "VIP-arrangement" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Popcorn", "Special" },
                values: new object[] { true, "" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Popcorn", "Special" },
                values: new object[] { true, "Kinderarrangement" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Popcorn",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Special",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 6, 12, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 6, 16, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 6, 20, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MovieId", "StartDateTime", "Type" },
                values: new object[] { 2, new DateTime(2023, 3, 3, 21, 37, 28, 166, DateTimeKind.Local).AddTicks(8964), "2D" });
        }
    }
}
