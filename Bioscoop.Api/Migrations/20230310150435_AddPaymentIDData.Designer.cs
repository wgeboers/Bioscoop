// <auto-generated />
using System;
using Bioscoop.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bioscoop.Api.Migrations
{
    [DbContext(typeof(BioscoopDbContext))]
    [Migration("20230310150435_AddPaymentIDData")]
    partial class AddPaymentIDData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            MovieId = 3,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3219),
                            Type = "2D"
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 3,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3292),
                            Type = "3D"
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 3,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3310),
                            Type = "3D-HFR"
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 3,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3328),
                            Type = "IMAX"
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 3,
                            RoomId = 2,
                            StartDateTime = new DateTime(2023, 3, 10, 16, 4, 35, 456, DateTimeKind.Local).AddTicks(3344),
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = 1,
                            PaymentID = "1",
                            Price = 9.00m,
                            RowNumber = 1,
                            SeatNumber = 1,
                            ShowId = 1
                        },
                        new
                        {
                            Id = 2,
                            Code = 2,
                            PaymentID = "2",
                            Price = 9.00m,
                            RowNumber = 1,
                            SeatNumber = 2,
                            ShowId = 1
                        },
                        new
                        {
                            Id = 3,
                            Code = 3,
                            PaymentID = "3",
                            Price = 8.50m,
                            RowNumber = 1,
                            SeatNumber = 3,
                            ShowId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
