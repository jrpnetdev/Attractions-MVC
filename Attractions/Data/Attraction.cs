using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attractions.Data
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string DetailsUrl { get; set; }
        public bool IsFeatured { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
    }
}