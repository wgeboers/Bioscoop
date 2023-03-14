using Bioscoop.Api.Entities;
using Bioscoop.Api.Extensions;
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
                Description_en = "In Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp.\r\n\r\nIn Ant-Man and the Wasp: Quantumania, superhero partners Scott Lang (Paul Rudd) and Hope van Dyne (Evangeline Lilly) return to the big screen to continue their adventures as Ant-Man and The Wasp. Together with Hope's parents Hank Pym (Michael Douglas) and Janet van Dyne (Michelle Pfeiffer), they explore the Quantum Realm, where strange new creatures cross their path. Thus they embark on an adventure that will take them beyond the limits of what they thought possible. Ant-Man and the Wasp: Quantumania stars Jonathan Majors as Kang. The movie is directed by Peyton Reed; Kevin Feige and Stephen Broussard are the producers.",
                Description_nl = "In Ant-Man and the Wasp: Quantumania keren superheldenpartners Scott Lang (Paul Rudd) en Hope van Dyne (Evangeline Lilly) terug op het grote doek om hun avonturen als Ant-Man en The Wasp voort te zetten.\r\n\r\nSamen met Hope’s ouders Hank Pym (Michael Douglas) en Janet van Dyne (Michelle Pfeiffer) verkennen ze de Quantum Realm, waarbij er vreemde nieuwe wezens op hun pad komen. Zo beginnen ze aan een avontuur dat ze voorbij de grenzen zal brengen van wat ze voor mogelijk hielden. In Ant-Man and the Wasp: Quantumania is Jonathan Majors te zien als Kang. De film wordt geregisseerd door Peyton Reed; Kevin Feige en Stephen Broussard zijn de producenten.",
                Genre = "Action",
                ImageURL = "/Images/Movies/ant-man.jpg",
                PlayTime = 124,
                MinimumAge = 12,
                special = false
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                Title = "Babylon",
                Description = "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood.",
                Description_en = "Babylon, written and directed by Damien Chazelle and starring Brad Pitt, Margot Robbie and Diego Calva, is an original story set in 1920s Los Angeles.\r\n\r\nAlso stars Jovan Adepo, Li Jun Li and Jean Smart star in this film about the rise and fall of diverse characters in an era of decadence in early Hollywood.",
                Description_nl = "Babylon, geschreven en geregisseerd door Damien Chazelle met Brad Pitt, Margot Robbie en Diego Calva in de hoofdrol, is een origineel verhaal dat zich afspeelt in het Los Angeles van de jaren 1920.\r\n\r\nOok o.a. Jovan Adepo, Li Jun Li en Jean Smart spelen in deze film over de opkomst en ondergang van diverse personages in een tijdperk van decadentie in het vroege Hollywood.",
                Genre = "Drama",
                ImageURL = "/Images/Movies/Babylon.jpg",
                PlayTime = 188,
                MinimumAge = 16,
                special = false
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Title = "Puss in boots: The last wish",
                Description = "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas.",
                Description_en = "This fall, our beloved, milk-drinking, reckless, fearless feline returns. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe.\r\n\r\nThis year, make every adventure feel like your last. For the first time in over a decade, DreamWorks Animation presents yet another adventure in the Shrek universe with the return of our beloved, milk-drinking, reckless, fearless feline in Puss in Boots: The Last Wish. In the original version, Antonio Banderas and Salma Hayek will return as Puss in Boots and Kitty Soft Pawas.",
                Description_nl = "Dit najaar keert onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige terug. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum.\r\n\r\nBeleef dit jaar elk avontuur alsof het je laatste is. Voor het eerst in ruim tien jaar presenteert DreamWorks Animation weer een nieuw avontuur in het Shrek-universum met de terugkeer van onze geliefde, melk drinkende, roekeloze, onbevreesde katachtige in Puss in Boots: The Last Wish. In de originele versie zullen Antonio Banderas en Salma Hayek terugkeren in de rol van Puss in Boots en Kitty Soft Pawas.",
                Genre = "Comedy",
                ImageURL = "/Images/Movies/PussInBootsTwo.jpg",
                PlayTime = 105,
                MinimumAge = 6,
                special = false
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 4,
                Title = "Avatar: The way of water",
                Description = "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen.",
                Description_en = "Avatar: The Way of Water tells the story of the Sully family (Jake, Neytiri and their children) and the struggles they face, the struggles they make to protect each other, the battles they must fight to stay alive and the tragedies they endure.",
                Description_nl = "Avatar: The Way of Water vertelt het verhaal van de familie Sully (Jake, Neytiri en hun kinderen) en de problemen waar ze tegenaan lopen, de moeite die ze doen om elkaar te beschermen, de gevechten die ze moeten aangaan om in leven te blijven en de tragedies die ze te verduren krijgen.",
                Genre = "Action",
                ImageURL = "/Images/Movies/AvatarTheWayOfTheWater.jpg",
                PlayTime = 192,
                MinimumAge = 12,
                special = false
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 5,
                Title = "The Whale",
                Description = "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things).",
                Description_en = "The Whale is a gripping drama featuring a phenomenal comeback from actor Brendan Fraser (The Mummy Trilogy, Crash) as a father trying to reconnect with his estranged teenage daughter, played by rising star Sadie Sink (Stranger Things).",
                Description_nl = "The Whale is een aangrijpend drama met een fenomenale comeback van acteur Brendan Fraser (The Mummy Trilogy, Crash) als vader, die probeert opnieuw contact te maken met zijn vervreemde tienerdochter, gespeeld door rising star Sadie Sink (Stranger Things).",
                Genre = "Action",
                ImageURL = "/Images/Movies/TheWhale.jpg",
                PlayTime = 117,
                MinimumAge = 12,
                special = false
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
            {
                Id = 1,
                MovieId = 3,
                RoomId = 2,
                StartDateTime = DateTime.Now,
                Type = "2D"
            });

            modelBuilder.Entity<Show>().HasData(new Show
            {
                Id = 2,
                MovieId = 3,
                RoomId = 2,
                StartDateTime = DateTime.Now,
                Type = "3D"
            });

            modelBuilder.Entity<Show>().HasData(new Show
            {
                Id = 3,
                MovieId = 3,
                RoomId = 2,
                StartDateTime = DateTime.Now,
                Type = "3D-HFR"
            });

            modelBuilder.Entity<Show>().HasData(new Show
            {
                Id = 4,
                MovieId = 3,
                RoomId = 2,
                StartDateTime = DateTime.Now,
                Type = "IMAX"
            });

            modelBuilder.Entity<Show>().HasData(new Show
            {
                Id = 5,
                MovieId = 3,
                RoomId = 2,
                StartDateTime = DateTime.Now,
                Type = "2D"
            });

            //Add Tickets
            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 1,
                Code = 000001,
                ShowId = 1,
                RowNumber = 1,
                SeatNumber = 1,
                Price = 9.00m,
                PaymentID = "1",
                Popcorn = false,
                Special = "VIP-arrangement"
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 2,
                Code = 000002,
                ShowId = 1,
                RowNumber = 1,
                SeatNumber = 2,
                Price = 9.00m,
                PaymentID = "2",
                Popcorn = true,
                Special = ""
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 3,
                Code = 000003,
                ShowId = 1,
                RowNumber = 1,
                SeatNumber = 3,
                Price = 8.50m,
                PaymentID = "3",
                Popcorn = true,
                Special = "Kinderarrangement"
            });
        }

        public DbSet<Movie> Movies { get; set;}
        public DbSet<Room> Rooms { get; set;}
        public DbSet<Show> Shows { get; set;}
        public DbSet<Ticket> Tickets { get; set; }
    }
}
