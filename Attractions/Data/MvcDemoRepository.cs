using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attractions.Data
{
    public class MvcDemoRepository : IRepository
    {
        private readonly MvcDemoContext _ctx;

        public MvcDemoRepository(MvcDemoContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Attraction> GetAllAttractions()
        {
            return _ctx.Attractions;
        }

        public IQueryable<Attraction> GetFeaturedAttractions()
        {
            return _ctx.Attractions.Where(a => a.IsFeatured);
        }

        public IQueryable<Attraction> FindAttractions(string searchText)
        {
            return _ctx.Attractions.Where(a => a.Title.ToLower().Contains(searchText.ToLower()));
        }

        public IQueryable<Attraction> FindAttractionsInContinent(string continent)
        {
            return _ctx.Attractions.Where(a => a.Continent.ToLower().Equals(continent.ToLower()));
        }

        public Attraction FindAttractionById(int id)
        {
            return _ctx.Attractions.FirstOrDefault(a => a.Id == id);
        }

    }
}