using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_en = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_nl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayTime = table.Column<int>(type: "int", nullable: false),
                    MinimumAge = table.Column<int>(type: "int", nullable: false),
                    special = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    Rows = table.Column<int>(type: "int", nullable: false),
                    WheelchairFriendly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ShowId = table.Column<int>(type: "int", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Popcorn = table.Column<bool>(type: "bit", nullable: false),
                    Special = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secret = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Description_en", "Description_nl", "Genre", "ImageURL", "MinimumAge", "PlayTime", "Title", "special" },
                values: new object[,]
                {
                    { 1, "In Ant-Man and the Wasp: Quantumania keren superheldenpartners Scott Lang (Paul Rudd) en Hope van Dyne (Evangeline Lilly) terug op het grote doek om hun avonturen als Ant-Man en The Wasp voort te zetten.\r\n\r\nSamen met Hope’s ouders Hank Pym (Michael Douglas) en Janet van Dyne (Michelle Pfeiffer) verkennen ze de Quantum Realm, waarbij er vreemde nieuwe wezens op hun pad komen. Zo beginnen ze aan een avontuur dat ze voorbij de grenzen zal brengen van wat ze voor mogelijk hielden. In Ant-Man and the Wasp: Quantumania is Jonathan Majors te zien als Kang. De film wordt geregisseerd door Peyton Reed; Kevin Feige en Stephen Broussard zijn de producenten.", "In Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp.\r\n\r\nIn Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp. Together with Hope's parents Hank Pym (Michael Douglas) and Janet van Dyne (Michelle Pfeiffer), they explore the Quantum Realm, where strange new creatures cross their path. Thus they embark on an adventure that will take them beyond the limits of what they thought possible. Ant-Man and the Wasp: Quantumania stars Jonathan Majors as Kang. The movie is directed by Peyton Reed; Kevin Feige and Stephen Broussard are the producers.", "In Ant-Man and the Wasp: Quantumania keren superheldenpartners Scott Lang (Paul Rudd) en Hope van Dyne (Evangeline Lilly) terug op het grote doek om hun avonturen als Ant-Man en The Wasp voort te zetten.\r\n\r\nSamen met Hope’s ouders Hank Pym (Michael Douglas) en Janet van Dyne (Michelle Pfeiffer) verkennen ze de Quantum Realm, waarbij er vreemde nieuwe wezens op hun pad komen. Zo beginnen ze aan een avontuur dat ze voorbij de grenzen zal brengen van wat ze voor mogelijk hielden. In Ant-Man and the Wasp: Quantumania is Jonathan Majors te zien als Kang. De film wordt geregisseerd door Peyton Reed; Kevin Feige en Stephen Broussard zijn de producenten.", "Action", "/Images/Movies/ant-man.jpg", 12, 124, "Ant-Man and the Wasp: Quantumania", false },
                    { 2, "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood.", "Babylon, written and directed by Damien Chazelle and starring Brad Pitt, Margot Robbie and Diego Calva, is an original story set in 1920s Los Angeles.\r\n\r\nAlso stars Jovan Adepo, Li Jun Li and Jean Smart star in this film about the rise and fall of diverse characters in an era of decadence in early Hollywood.", "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood.", "Drama", "/Images/Movies/Babylon.jpg", 16, 188, "Babylon", false },
                    { 3, "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas.", "This fall, our beloved, milk-drinking, reckless, fearless feline returns. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe.\r\n\r\nThis year, make every adventure feel like your last. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe with the return of our beloved, milk-drinking, reckless, fearless feline in Puss in Boots: The Last Wish. In the original version, Antonio Banderas and Salma Hayek will return as Puss in Boots and Kitty Soft Pawas.", "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas.", "Comedy", "/Images/Movies/PussInBootsTwo.jpg", 6, 105, "Puss in boots: The last wish", false },
                    { 4, "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen.", "Avatar: The Way of Water tells the story of the Sully family (Jake, Neytiri and their children) and the struggles they face, the struggles they make to protect each other, the battles they must fight to stay alive and the tragedies they endure.", "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen.", "Action", "/Images/Movies/AvatarTheWayOfTheWater.jpg", 12, 192, "Avatar: The way of water", false },
                    { 5, "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things).", "The Whale is a gripping drama featuring a phenomenal comeback from actor Brendan Fraser (The Mummy Trilogy, Crash) as a father trying to reconnect with his estranged teenage daughter, played by rising star Sadie Sink (Stranger Things).", "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things).", "Action", "/Images/Movies/TheWhale.jpg", 12, 117, "The Whale", false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Rows", "Seats", "WheelchairFriendly" },
                values: new object[,]
                {
                    { 1, "Zaal 1", 8, 120, true },
                    { 2, "Zaal 2", 8, 120, true },
                    { 3, "Zaal 3", 8, 120, true },
                    { 4, "Zaal 4", 6, 60, true },
                    { 5, "Zaal 5", 4, 50, false },
                    { 6, "Zaal 6", 4, 50, false }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "MovieId", "RoomId", "StartDateTime", "Type" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 3, 27, 12, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 2, 1, 1, new DateTime(2023, 3, 27, 16, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 3, 1, 1, new DateTime(2023, 3, 27, 20, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 4, 2, 2, new DateTime(2023, 3, 27, 13, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 5, 2, 2, new DateTime(2023, 3, 27, 17, 0, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 6, 2, 2, new DateTime(2023, 3, 27, 20, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 7, 3, 3, new DateTime(2023, 3, 27, 14, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 8, 3, 3, new DateTime(2023, 3, 27, 18, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 9, 3, 3, new DateTime(2023, 3, 27, 22, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 10, 4, 4, new DateTime(2023, 3, 27, 15, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 11, 4, 4, new DateTime(2023, 3, 27, 19, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 12, 4, 4, new DateTime(2023, 3, 27, 23, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 13, 5, 5, new DateTime(2023, 3, 27, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 14, 5, 5, new DateTime(2023, 3, 27, 15, 30, 0, 0, DateTimeKind.Local), "3D" },
                    { 15, 5, 5, new DateTime(2023, 3, 27, 19, 30, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 16, 1, 1, new DateTime(2023, 3, 28, 12, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 17, 2, 2, new DateTime(2023, 3, 28, 16, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 18, 3, 3, new DateTime(2023, 3, 28, 20, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 19, 4, 4, new DateTime(2023, 3, 28, 13, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 20, 5, 5, new DateTime(2023, 3, 28, 17, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 21, 1, 1, new DateTime(2023, 3, 29, 20, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 22, 2, 2, new DateTime(2023, 3, 29, 14, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 23, 3, 3, new DateTime(2023, 3, 29, 18, 0, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 24, 4, 4, new DateTime(2023, 3, 29, 22, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 25, 5, 5, new DateTime(2023, 3, 29, 15, 0, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 26, 1, 1, new DateTime(2023, 3, 30, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 27, 2, 2, new DateTime(2023, 3, 30, 23, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 28, 3, 3, new DateTime(2023, 3, 30, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 29, 4, 4, new DateTime(2023, 3, 30, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 30, 5, 5, new DateTime(2023, 3, 30, 19, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 31, 1, 1, new DateTime(2023, 3, 31, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 32, 2, 2, new DateTime(2023, 3, 31, 23, 0, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 33, 3, 3, new DateTime(2023, 3, 31, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 34, 4, 4, new DateTime(2023, 3, 31, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 35, 5, 5, new DateTime(2023, 3, 31, 19, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 36, 1, 1, new DateTime(2023, 4, 1, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 37, 2, 2, new DateTime(2023, 4, 1, 23, 0, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 38, 3, 3, new DateTime(2023, 4, 1, 11, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 39, 4, 4, new DateTime(2023, 4, 1, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 40, 5, 5, new DateTime(2023, 4, 1, 19, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 41, 1, 1, new DateTime(2023, 3, 26, 19, 0, 0, 0, DateTimeKind.Local), "3D" },
                    { 42, 2, 2, new DateTime(2023, 3, 26, 23, 0, 0, 0, DateTimeKind.Local), "2D" },
                    { 43, 3, 3, new DateTime(2023, 3, 26, 11, 30, 0, 0, DateTimeKind.Local), "3D-HFR" },
                    { 44, 4, 4, new DateTime(2023, 3, 26, 15, 30, 0, 0, DateTimeKind.Local), "IMAX" },
                    { 45, 5, 5, new DateTime(2023, 3, 26, 19, 30, 0, 0, DateTimeKind.Local), "2D" },
                    { 46, 1, 1, new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8274), "3D" },
                    { 47, 2, 2, new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8327), "2D" },
                    { 48, 3, 3, new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8334), "3D-HFR" },
                    { 49, 4, 4, new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8341), "IMAX" },
                    { 50, 5, 5, new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8348), "2D" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Code", "PaymentID", "Popcorn", "Price", "RowNumber", "SeatNumber", "Secret", "ShowId", "Special" },
                values: new object[,]
                {
                    { 1, 1, "1", false, 9.00m, 1, 1, null, 1, "VIP-arrangement" },
                    { 2, 2, "2", true, 9.00m, 1, 2, null, 1, "" },
                    { 3, 3, "3", true, 8.50m, 1, 3, null, 1, "Kinderarrangement" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
