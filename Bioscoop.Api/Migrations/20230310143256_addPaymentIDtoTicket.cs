using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class addPaymentIDtoTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentID",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 10, 15, 32, 56, 758, DateTimeKind.Local).AddTicks(9364), "2D" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 10, 15, 32, 56, 758, DateTimeKind.Local).AddTicks(9424), "3D" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[] { 3, 2, new DateTime(2023, 3, 10, 15, 32, 56, 758, DateTimeKind.Local).AddTicks(9464), "3D-HFR" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MovieId", "StartDateTime", "Type" },
                values: new object[] { 3, new DateTime(2023, 3, 10, 15, 32, 56, 758, DateTimeKind.Local).AddTicks(9474), "IMAX" });

          

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentID",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "PaymentID",
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
