using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class fillDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 57, 18, 338, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 57, 18, 338, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 57, 18, 338, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 57, 18, 338, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 57, 18, 338, DateTimeKind.Local).AddTicks(7732));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 18, 52, 6, 494, DateTimeKind.Local).AddTicks(5207));
        }
    }
}
