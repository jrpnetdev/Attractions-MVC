using Attractions.Data;

namespace Attractions.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcDemoContext context)
        {
            context.Attractions.AddOrUpdate(x => x.Id,
                new Attraction() { Id = 1, Title = "London", Type = "Plus", ImageUrl = "/Content/pics/london-eye.jpg", Price = 95.95M, DetailsUrl = "http", IsFeatured = false, Country = "UK", Continent = "Europe" },
                new Attraction() { Id = 2, Title = "Sydney", Type = "Plus", ImageUrl = "/Content/pics/sydney.jpg", Price = 995.95M, DetailsUrl = "http", IsFeatured = true, Country = "Australia", Continent = "Australia" },
                new Attraction() { Id = 3, Title = "Florida", Type = "Fun & Sun", ImageUrl = "/Content/pics/seaworld-orlando.jpg", Price = 695.95M, DetailsUrl = "http", IsFeatured = true, Country = "US", Continent = "North America" },
                new Attraction() { Id = 4, Title = "China", Type = "Tour", ImageUrl = "/Content/pics/china.jpg", Price = 495.95M, DetailsUrl = "http", IsFeatured = true, Country = "China", Continent = "Asia" },
                new Attraction() { Id = 5, Title = "Universal", Type = "Tour", ImageUrl = "/Content/pics/Universal-Studios.jpg", Price = 1999.99M, DetailsUrl = "http", IsFeatured = true, Country = "US", Continent = "North America" },
                new Attraction() { Id = 6, Title = "London", Type = "Dungeon", ImageUrl = "/Content/pics/london-dungeon.jpg", Price = 95.95M, DetailsUrl = "http", IsFeatured = false, Country = "UK", Continent = "Europe" },
                new Attraction() { Id = 7, Title = "Paris", Type = "Tour", ImageUrl = "/Content/pics/the-eiffel-tower-tour.jpg", Price = 295.95M, DetailsUrl = "http", IsFeatured = true, Country = "France", Continent = "Europe" },
                new Attraction() { Id = 8, Title = "Athens", Type = "Plus", ImageUrl = "/Content/pics/athens-city-tour.jpg", Price = 395.95M, DetailsUrl = "http", IsFeatured = true, Country = "Greece", Continent = "Europe" },
                new Attraction() { Id = 9, Title = "Dubai", Type = "City Tour", ImageUrl = "/Content/pics/dubai-city-tour.jpg", Price = 95.95M, DetailsUrl = "http", IsFeatured = false, Country = "UAE", Continent = "Asia" },
                new Attraction() { Id = 10, Title = "Copenhagen", Type = "Tour", ImageUrl = "/Content/pics/copenhagen.jpg", Price = 995.95M, DetailsUrl = "http", IsFeatured = false, Country = "Denmark", Continent = "Europe" },
                new Attraction() { Id = 11, Title = "Beijing", Type = "Plus", ImageUrl = "/Content/pics/classic-beijing.jpg", Price = 695.95M, DetailsUrl = "http", IsFeatured = true, Country = "China", Continent = "Asia" },
                new Attraction() { Id = 12, Title = "Lisbon", Type = "Tour", ImageUrl = "/Content/pics/lisbon.jpg", Price = 495.95M, DetailsUrl = "http", IsFeatured = false, Country = "Portugal", Continent = "Europe" },
                new Attraction() { Id = 13, Title = "London", Type = "Aquarium", ImageUrl = "/Content/pics/london-aquarium.jpg", Price = 395.95M, DetailsUrl = "http", IsFeatured = true, Country = "UK", Continent = "Europe" },
                new Attraction() { Id = 14, Title = "Milan", Type = "City Tour", ImageUrl = "/Content/pics/Milan.jpg", Price = 95.95M, DetailsUrl = "http", IsFeatured = false, Country = "Italy", Continent = "Europe" },
                new Attraction() { Id = 15, Title = "Bangkok", Type = "Sights", ImageUrl = "/Content/pics/bangkok.jpg", Price = 295.95M, DetailsUrl = "http", IsFeatured = false, Country = "Thailand", Continent = "Asia" },
                new Attraction() { Id = 16, Title = "Munich", Type = "City Tour", ImageUrl = "/Content/pics/munich.jpg", Price = 899.99M, DetailsUrl = "http", IsFeatured = false, Country = "Germany", Continent = "Europe" },
                new Attraction() { Id = 17, Title = "Aqualand", Type = "Algarve", ImageUrl = "/Content/pics/aqualand-algarve.jpg", Price = 1050.00M, DetailsUrl = "http", IsFeatured = false, Country = "Portugal", Continent = "Europe" },
                new Attraction() { Id = 18, Title = "Big Bus", Type = "Tours", ImageUrl = "/Content/pics/big-bus-tours-paris.jpg", Price = 450.00M, DetailsUrl = "http", IsFeatured = false, Country = "France", Continent = "Europe" },
                new Attraction() { Id = 19, Title = "Lima City", Type = "Tour", ImageUrl = "/Content/pics/city-sightseeing-lima.jpg", Price = 1250.50M, DetailsUrl = "http", IsFeatured = false, Country = "Peru", Continent = "South America" },
                new Attraction() { Id = 20, Title = "Egypt Ocean", Type = "Scuba", ImageUrl = "/Content/pics/egypt-ocean.jpg", Price = 750.00M, DetailsUrl = "http", IsFeatured = false, Country = "Egypt", Continent = "Africa" },
                new Attraction() { Id = 21, Title = "Benidorm", Type = "Adventure", ImageUrl = "/Content/pics/terra-mitica.jpg", Price = 1200.00M, DetailsUrl = "http", IsFeatured = false, Country = "Spain", Continent = "Europe" },
                new Attraction() { Id = 22, Title = "Dolphin", Type = "Adventure", ImageUrl = "/Content/pics/dolphin-adventure.jpg", Price = 2185.75M, DetailsUrl = "http", IsFeatured = false, Country = "US", Continent = "North America" },
                new Attraction() { Id = 23, Title = "Sahara", Type = "Adventure", ImageUrl = "/Content/pics/sahara-adventure.jpg", Price = 1500.00M, DetailsUrl = "http", IsFeatured = false, Country = "Tunisia", Continent = "Africa" },
                new Attraction() { Id = 24, Title = "Olympic", Type = "Adventure", ImageUrl = "/Content/pics/olympic-adventure.jpg", Price = 29.95M, DetailsUrl = "http", IsFeatured = false, Country = "UK", Continent = "Europe" },
                new Attraction() { Id = 25, Title = "Egypt", Type = "Pyramids", ImageUrl = "/Content/pics/pyramids-egypt.jpg", Price = 2475.99M, DetailsUrl = "http", IsFeatured = false, Country = "Egypt", Continent = "Africa" },
                new Attraction() { Id = 26, Title = "Brazil", Type = "Tour", ImageUrl = "/Content/pics/brazil-tour.jpg", Price = 1450.00M, DetailsUrl = "http", IsFeatured = false, Country = "Brazil", Continent = "South America" },
                new Attraction() { Id = 27, Title = "Buenos Aires", Type = "Tour", ImageUrl = "/Content/pics/buenos-aires-tour.jpg", Price = 2599.00M, DetailsUrl = "http", IsFeatured = false, Country = "Argentina", Continent = "South America" },
                new Attraction() { Id = 28, Title = "Chile", Type = "Stargazing", ImageUrl = "/Content/pics/chilie-stargazing.jpg", Price = 2199.99M, DetailsUrl = "http", IsFeatured = false, Country = "Chile", Continent = "South America" },
                new Attraction() { Id = 29, Title = "Venice", Type = "Sights", ImageUrl = "/Content/pics/venice-tour.jpg", Price = 599.99M, DetailsUrl = "http", IsFeatured = false, Country = "Italy", Continent = "Europe" },
                new Attraction() { Id = 30, Title = "Thailand", Type = "Tour", ImageUrl = "/Content/pics/thailand-tour.jpg", Price = 2300.00M, DetailsUrl = "http", IsFeatured = false, Country = "Thailand", Continent = "Asia" },
                new Attraction() { Id = 31, Title = "Aztec", Type = "Adventure", ImageUrl = "/Content/pics/Aztec-adventure.jpg", Price = 1150.00M, DetailsUrl = "http", IsFeatured = false, Country = "Peru", Continent = "South America" },
                new Attraction() { Id = 32, Title = "Bahamas", Type = "Fun & Sun", ImageUrl = "/Content/pics/bahamas-sun.jpg", Price = 2799.00M, DetailsUrl = "http", IsFeatured = false, Country = "Bahamas", Continent = "North America" },
                new Attraction() { Id = 33, Title = "Los Angeles", Type = "Tour", ImageUrl = "/Content/pics/los-angeles-tour.jpg", Price = 1780.00M, DetailsUrl = "http", IsFeatured = false, Country = "US", Continent = "North America" },
                new Attraction() { Id = 34, Title = "Malaysia", Type = "Fun & Sun", ImageUrl = "/Content/pics/malaysia-water-park.jpg", Price = 4799.00M, DetailsUrl = "http", IsFeatured = false, Country = "Malaysia", Continent = "Asia" },
                new Attraction() { Id = 35, Title = "Oman", Type = "Adventure", ImageUrl = "/Content/pics/oman-tour.jpg", Price = 1555.00M, DetailsUrl = "http", IsFeatured = false, Country = "Oman", Continent = "Asia" },
                new Attraction() { Id = 36, Title = "Moscow", Type = "Tours", ImageUrl = "/Content/pics/moscow-tours.jpg", Price = 1999.99M, DetailsUrl = "http", IsFeatured = false, Country = "Russia", Continent = "Europe" },
                new Attraction() { Id = 37, Title = "Berlin", Type = "Tour", ImageUrl = "/Content/pics/berlin.jpg", Price = 999.99M, DetailsUrl = "http", IsFeatured = false, Country = "Germany", Continent = "Europe" }
            );

            //context.Users.AddOrUpdate(x => x.Id,
            //new User { Id = 1, Username = "James", Password = "Password", Favourites =  }
            //);
        }
    }
}