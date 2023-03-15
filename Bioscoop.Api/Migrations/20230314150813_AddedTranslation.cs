using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description_en",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description_nl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description_en", "Description_nl" },
                values: new object[] { "In Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp.\r\n\r\nIn Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp. Together with Hope's parents Hank Pym (Michael Douglas) and Janet van Dyne (Michelle Pfeiffer), they explore the Quantum Realm, where strange new creatures cross their path. Thus they embark on an adventure that will take them beyond the limits of what they thought possible. Ant-Man and the Wasp: Quantumania stars Jonathan Majors as Kang. The movie is directed by Peyton Reed; Kevin Feige and Stephen Broussard are the producers.", "In Ant-Man and the Wasp: Quantumania keren superheldenpartners Scott Lang (Paul Rudd) en Hope van Dyne (Evangeline Lilly) terug op het grote doek om hun avonturen als Ant-Man en The Wasp voort te zetten.\r\n\r\nSamen met Hope’s ouders Hank Pym (Michael Douglas) en Janet van Dyne (Michelle Pfeiffer) verkennen ze de Quantum Realm, waarbij er vreemde nieuwe wezens op hun pad komen. Zo beginnen ze aan een avontuur dat ze voorbij de grenzen zal brengen van wat ze voor mogelijk hielden. In Ant-Man and the Wasp: Quantumania is Jonathan Majors te zien als Kang. De film wordt geregisseerd door Peyton Reed; Kevin Feige en Stephen Broussard zijn de producenten." });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description_en", "Description_nl" },
                values: new object[] { "Babylon, written and directed by Damien Chazelle and starring Brad Pitt, Margot Robbie and Diego Calva, is an original story set in 1920s Los Angeles.\r\n\r\nAlso stars Jovan Adepo, Li Jun Li and Jean Smart star in this film about the rise and fall of diverse characters in an era of decadence in early Hollywood.", "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood." });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description_en", "Description_nl" },
                values: new object[] { "This fall, our beloved, milk-drinking, reckless, fearless feline returns. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe.\r\n\r\nThis year, make every adventure feel like your last. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe with the return of our beloved, milk-drinking, reckless, fearless feline in Puss in Boots: The Last Wish. In the original version, Antonio Banderas and Salma Hayek will return as Puss in Boots and Kitty Soft Pawas.", "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas." });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description_en", "Description_nl" },
                values: new object[] { "Avatar: The Way of Water tells the story of the Sully family (Jake, Neytiri and their children) and the struggles they face, the struggles they make to protect each other, the battles they must fight to stay alive and the tragedies they endure.", "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen." });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description_en", "Description_nl" },
                values: new object[] { "The Whale is a gripping drama featuring a phenomenal comeback from actor Brendan Fraser (The Mummy Trilogy, Crash) as a father trying to reconnect with his estranged teenage daughter, played by rising star Sadie Sink (Stranger Things).", "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things)." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description_en",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Description_nl",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDateTime",
                value: new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3344));
        }
    }
}
