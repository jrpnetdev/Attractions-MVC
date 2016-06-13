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
                new Attraction() { Id = 16, Title = "Berlin", Type = "Tour", ImageUrl = "/Content/pics/berlin.jpg", Price = 999.99M, DetailsUrl = "http", IsFeatured = false, Country = "Germany", Continent = "Europe" }
            );

            //new Attraction() { Id = 12, Title = "Dublin", Type = "Tour", ImageUrl = "/Content/pics/Dublin.jpg", Price = 495.95M, DetailsUrl = "http", IsFeatured = true, Country = "Ireland", Continent = "Europe" }

            //context.Users.AddOrUpdate(x => x.Id,
            //new User { Id = 1, Username = "James", Password = "Password", Favourites =  }
            //);
        }
    }
}