using Bioscoop.Api.Entities;
using Bioscoop.Api.Extensions;
using Bioscoop.Api.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Api.Data
{
    public class BioscoopDbContext:DbContext
    {
        public BioscoopDbContext(DbContextOptions<BioscoopDbContext> options):base(options)
        {

        }

        private static DateTime today = DateTime.Now;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Add movies
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 1,
                Title = "Ant-Man and the Wasp: Quantumania",
                Description = "In Ant-Man and the Wasp: Quantumania keren superheldenpartners Scott Lang (Paul Rudd) en Hope van Dyne (Evangeline Lilly) terug op het grote doek om hun avonturen als Ant-Man en The Wasp voort te zetten.\r\n\r\nSamen met Hope’s ouders Hank Pym (Michael Douglas) en Janet van Dyne (Michelle Pfeiffer) verkennen ze de Quantum Realm, waarbij er vreemde nieuwe wezens op hun pad komen. Zo beginnen ze aan een avontuur dat ze voorbij de grenzen zal brengen van wat ze voor mogelijk hielden. In Ant-Man and the Wasp: Quantumania is Jonathan Majors te zien als Kang. De film wordt geregisseerd door Peyton Reed; Kevin Feige en Stephen Broussard zijn de producenten.",
                ImageURL = "/Images/Movies/ant-man.jpg",
                PlayTime = 124,
                MinimumAge = 12
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                Title = "Babylon",
                Description = "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood.",
                ImageURL = "/Images/Movies/Babylon.jpg",
                PlayTime = 188,
                MinimumAge = 16
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Title = "Puss in boots: The last wish",
                Description = "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas.",
                ImageURL = "/Images/Movies/PussInBootsTwo.jpg",
                PlayTime = 105,
                MinimumAge = 6
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 4,
                Title = "Avatar: The way of water",
                Description = "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen.",
                ImageURL = "/Images/Movies/AvatarTheWayOfTheWater.jpg",
                PlayTime = 192,
                MinimumAge = 12
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 5,
                Title = "The Whale",
                Description = "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things).",
                ImageURL = "/Images/Movies/TheWhale.jpg",
                PlayTime = 117,
                MinimumAge = 12
            });

            //Add Rooms
            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = 1,
                Name = "Zaal 1",
                Seats = 120,
                Rows = 8,
                WheelchairFriendly = true
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = 2,
                Name = "Zaal 2",
                Seats = 120,
                Rows = 8,
                WheelchairFriendly = true
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = 3,
                Name = "Zaal 3",
                Seats = 120,
                Rows = 8,
                WheelchairFriendly = true
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = 4,
                Name = "Zaal 4",
                Seats = 60,
                Rows = 6,
                WheelchairFriendly = true
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = 5,
                Name = "Zaal 5",
                Seats = 50,
                Rows = 4,
                WheelchairFriendly = false
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = 6,
                Name = "Zaal 6",
                Seats = 50,
                Rows = 4,
                WheelchairFriendly = false
            });

            //Add Shows
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 1, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 12, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 2, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 16, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 3, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 20, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 4, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 13, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 5, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 17, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 6, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 20, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 7, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 14, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 8, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 18, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 9, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 22, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 10, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 15, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 11, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 19, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 12, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 23, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 13, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 11, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 14, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 15, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 15, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Monday, 19, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 16, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 12, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 17, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 16, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 18, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 20, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 19, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 13, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 20, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Tuesday, 17, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 21, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Wednesday, 20, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 22, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Wednesday, 14, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 23, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Wednesday, 18, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 24, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Wednesday, 22, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 25, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Wednesday, 15, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 26, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 19, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 27, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 23, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 28, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 11, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 29, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 15, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 30, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Thursday, 19, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 31, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 19, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 32, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 23, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 33, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 11, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 34, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 15, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 35, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Friday, 19, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 36, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 19, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 37, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 23, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 38, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 11, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 39, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 15, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 40, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Saturday, 19, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 41, MovieId = 1, RoomId = 1, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 19, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 42, MovieId = 2, RoomId = 2, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 23, 0) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 43, MovieId = 3, RoomId = 3, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 11, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 44, MovieId = 4, RoomId = 4, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 15, 30) });
            modelBuilder.Entity<Show>().HasData(new Show
            { Id = 45, MovieId = 5, RoomId = 5, StartDateTime = today.NextDayAt(DayOfWeek.Sunday, 19, 30) });

            //Add Tickets
            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 1,
                Code = 000001,
                ShowId = 1,
                RowNumber = 1,
                SeatNumber = 1,
                Price = 9.00m
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 2,
                Code = 000002,
                ShowId = 1,
                RowNumber = 1,
                SeatNumber = 2,
                Price = 9.00m
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 3,
                Code = 000003,
                ShowId = 1,
                RowNumber = 1,
                SeatNumber = 3,
                Price = 8.50m
            });

            //Add Options
            modelBuilder.Entity<Option>().HasData(new Option
            {
                Id = 1,
                Price = 4.00m
            });
        }

        public DbSet<Movie> Movies { get; set;}
        public DbSet<Room> Rooms { get; set;}
        public DbSet<Show> Shows { get; set;}
        public DbSet<Ticket> Tickets { get; set;}
        public DbSet<Option> Options { get; set;}
    }
}
