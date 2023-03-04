using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class MovieEntityAdditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "special",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Type", "special" },
                values: new object[] { "Action", "3D", false });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Genre", "Type", "special" },
                values: new object[] { "Drama", "Imax", false });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Genre", "Type", "special" },
                values: new object[] { "Comedy", "2D", false });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Genre", "Type", "special" },
                values: new object[] { "Action", "3D-HFR", false });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Genre", "Type", "special" },
                values: new object[] { "Action", "2D", false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 3, 21, 21, 32, 501, DateTimeKind.Local).AddTicks(7004));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "special",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 3, 10, 6, 27, 96, DateTimeKind.Local).AddTicks(7736));
        }
    }
}
