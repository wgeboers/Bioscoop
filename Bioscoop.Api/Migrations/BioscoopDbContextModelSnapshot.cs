﻿// <auto-generated />
using System;
using Bioscoop.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    [DbContext(typeof(BioscoopDbContext))]
    partial class BioscoopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bioscoop.Api.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description_nl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinimumAge")
                        .HasColumnType("int");

                    b.Property<int>("PlayTime")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("special")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "In Ant-Man and the Wasp: Quantumania keren superheldenpartners Scott Lang (Paul Rudd) en Hope van Dyne (Evangeline Lilly) terug op het grote doek om hun avonturen als Ant-Man en The Wasp voort te zetten.\r\n\r\nSamen met Hope’s ouders Hank Pym (Michael Douglas) en Janet van Dyne (Michelle Pfeiffer) verkennen ze de Quantum Realm, waarbij er vreemde nieuwe wezens op hun pad komen. Zo beginnen ze aan een avontuur dat ze voorbij de grenzen zal brengen van wat ze voor mogelijk hielden. In Ant-Man and the Wasp: Quantumania is Jonathan Majors te zien als Kang. De film wordt geregisseerd door Peyton Reed; Kevin Feige en Stephen Broussard zijn de producenten.",
                            Description_en = "In Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp.\r\n\r\nIn Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp. Together with Hope's parents Hank Pym (Michael Douglas) and Janet van Dyne (Michelle Pfeiffer), they explore the Quantum Realm, where strange new creatures cross their path. Thus they embark on an adventure that will take them beyond the limits of what they thought possible. Ant-Man and the Wasp: Quantumania stars Jonathan Majors as Kang. The movie is directed by Peyton Reed; Kevin Feige and Stephen Broussard are the producers.",
                            Description_nl = "In Ant-Man and the Wasp: Quantumania keren superheldenpartners Scott Lang (Paul Rudd) en Hope van Dyne (Evangeline Lilly) terug op het grote doek om hun avonturen als Ant-Man en The Wasp voort te zetten.\r\n\r\nSamen met Hope’s ouders Hank Pym (Michael Douglas) en Janet van Dyne (Michelle Pfeiffer) verkennen ze de Quantum Realm, waarbij er vreemde nieuwe wezens op hun pad komen. Zo beginnen ze aan een avontuur dat ze voorbij de grenzen zal brengen van wat ze voor mogelijk hielden. In Ant-Man and the Wasp: Quantumania is Jonathan Majors te zien als Kang. De film wordt geregisseerd door Peyton Reed; Kevin Feige en Stephen Broussard zijn de producenten.",
                            Genre = "Action",
                            ImageURL = "/Images/Movies/ant-man.jpg",
                            MinimumAge = 12,
                            PlayTime = 124,
                            Title = "Ant-Man and the Wasp: Quantumania",
                            special = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood.",
                            Description_en = "Babylon, written and directed by Damien Chazelle and starring Brad Pitt, Margot Robbie and Diego Calva, is an original story set in 1920s Los Angeles.\r\n\r\nAlso stars Jovan Adepo, Li Jun Li and Jean Smart star in this film about the rise and fall of diverse characters in an era of decadence in early Hollywood.",
                            Description_nl = "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood.",
                            Genre = "Drama",
                            ImageURL = "/Images/Movies/Babylon.jpg",
                            MinimumAge = 16,
                            PlayTime = 188,
                            Title = "Babylon",
                            special = false
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas.",
                            Description_en = "This fall, our beloved, milk-drinking, reckless, fearless feline returns. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe.\r\n\r\nThis year, make every adventure feel like your last. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe with the return of our beloved, milk-drinking, reckless, fearless feline in Puss in Boots: The Last Wish. In the original version, Antonio Banderas and Salma Hayek will return as Puss in Boots and Kitty Soft Pawas.",
                            Description_nl = "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas.",
                            Genre = "Comedy",
                            ImageURL = "/Images/Movies/PussInBootsTwo.jpg",
                            MinimumAge = 6,
                            PlayTime = 105,
                            Title = "Puss in boots: The last wish",
                            special = false
                        },
                        new
                        {
                            Id = 4,
                            Description = "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen.",
                            Description_en = "Avatar: The Way of Water tells the story of the Sully family (Jake, Neytiri and their children) and the struggles they face, the struggles they make to protect each other, the battles they must fight to stay alive and the tragedies they endure.",
                            Description_nl = "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen.",
                            Genre = "Action",
                            ImageURL = "/Images/Movies/AvatarTheWayOfTheWater.jpg",
                            MinimumAge = 12,
                            PlayTime = 192,
                            Title = "Avatar: The way of water",
                            special = false
                        },
                        new
                        {
                            Id = 5,
                            Description = "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things).",
                            Description_en = "The Whale is a gripping drama featuring a phenomenal comeback from actor Brendan Fraser (The Mummy Trilogy, Crash) as a father trying to reconnect with his estranged teenage daughter, played by rising star Sadie Sink (Stranger Things).",
                            Description_nl = "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things).",
                            Genre = "Action",
                            ImageURL = "/Images/Movies/TheWhale.jpg",
                            MinimumAge = 12,
                            PlayTime = 117,
                            Title = "The Whale",
                            special = false
                        });
                });

            modelBuilder.Entity("Bioscoop.Api.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rows")
                        .HasColumnType("int");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<bool>("WheelchairFriendly")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Zaal 1",
                            Rows = 8,
                            Seats = 120,
                            WheelchairFriendly = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Zaal 2",
                            Rows = 8,
                            Seats = 120,
                            WheelchairFriendly = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Zaal 3",
                            Rows = 8,
                            Seats = 120,
                            WheelchairFriendly = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Zaal 4",
                            Rows = 6,
                            Seats = 60,
                            WheelchairFriendly = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "Zaal 5",
                            Rows = 4,
                            Seats = 50,
                            WheelchairFriendly = false
                        },
                        new
                        {
                            Id = 6,
                            Name = "Zaal 6",
                            Rows = 4,
                            Seats = 50,
                            WheelchairFriendly = false
                        });
                });

            modelBuilder.Entity("Bioscoop.Api.Entities.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 27, 12, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 27, 16, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 27, 20, 0, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 27, 13, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 27, 17, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 6,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 27, 20, 0, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 7,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 27, 14, 0, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 8,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 27, 18, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 9,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 27, 22, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 10,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 27, 15, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 11,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 27, 19, 0, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 12,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 27, 23, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 13,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 27, 11, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 14,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 27, 15, 30, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 15,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 27, 19, 30, 0, 0, DateTimeKind.Local),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 16,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 28, 12, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 17,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 28, 16, 0, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 18,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 28, 20, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 19,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 28, 13, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 20,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 28, 17, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 21,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 29, 20, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 22,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 29, 14, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 23,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 29, 18, 0, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 24,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 29, 22, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 25,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 29, 15, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 26,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 30, 19, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 27,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 30, 23, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 28,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 30, 11, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 29,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 30, 15, 30, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 30,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 30, 19, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 31,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 31, 19, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 32,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 31, 23, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 33,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 31, 11, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 34,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 31, 15, 30, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 35,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 31, 19, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 36,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 4, 1, 19, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 37,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 4, 1, 23, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 38,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 4, 1, 11, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 39,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 4, 1, 15, 30, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 40,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 4, 1, 19, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 41,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 26, 19, 0, 0, 0, DateTimeKind.Local),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 42,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 26, 23, 0, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 43,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 26, 11, 30, 0, 0, DateTimeKind.Local),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 44,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 26, 15, 30, 0, 0, DateTimeKind.Local),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 45,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 26, 19, 30, 0, 0, DateTimeKind.Local),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 46,
                            MovieId = 1,
                            RoomId = 1,
                            StartDateTime = new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8274),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 47,
                            MovieId = 2,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8327),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 48,
                            MovieId = 3,
                            RoomId = 3,
                            StartDateTime = new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8334),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 49,
                            MovieId = 4,
                            RoomId = 4,
                            StartDateTime = new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8341),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 50,
                            MovieId = 5,
                            RoomId = 5,
                            StartDateTime = new DateTime(2023, 3, 26, 20, 56, 15, 536, DateTimeKind.Local).AddTicks(8348),
                            Type = "2D"
                        });
                });

            modelBuilder.Entity("Bioscoop.Api.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("PaymentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Popcorn")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("Secret")
                        .HasColumnType("bit");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<string>("Special")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = 1,
                            PaymentID = "1",
                            Popcorn = false,
                            Price = 9.00m,
                            RowNumber = 1,
                            SeatNumber = 1,
                            ShowId = 1,
                            Special = "VIP-arrangement"
                        },
                        new
                        {
                            Id = 2,
                            Code = 2,
                            PaymentID = "2",
                            Popcorn = true,
                            Price = 9.00m,
                            RowNumber = 1,
                            SeatNumber = 2,
                            ShowId = 1,
                            Special = ""
                        },
                        new
                        {
                            Id = 3,
                            Code = 3,
                            PaymentID = "3",
                            Popcorn = true,
                            Price = 8.50m,
                            RowNumber = 1,
                            SeatNumber = 3,
                            ShowId = 1,
                            Special = "Kinderarrangement"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
