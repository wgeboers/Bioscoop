using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class secret : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Secret",
                table: "Tickets",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 15, 21, 1, 7, 691, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Secret",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Secret",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Secret",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Secret",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 16, 8, 13, 207, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 16, 8, 13, 207, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 16, 8, 13, 207, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 16, 8, 13, 207, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 14, 16, 8, 13, 207, DateTimeKind.Local).AddTicks(8663));
        }
    }
}
