using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class ShowEntityAddition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "StartDateTime", "Type" },
                values: new object[] { new DateTime(2023, 3, 3, 21, 37, 28, 166, DateTimeKind.Local).AddTicks(8964), "2D" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Shows");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "3D");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Imax");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "2D");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "3D-HFR");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "2D");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 3, 21, 21, 32, 501, DateTimeKind.Local).AddTicks(7004));
        }
    }
}
