using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attractions.Data
{
    public class MvcDemoRepository : IRepository
    {
        private readonly MvcDemoContext _ctx;

       // private List<Attraction> _favourites;

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

        public Attraction FindAttractionById(int id)
        {
            return _ctx.Attractions.FirstOrDefault(a => a.Id == id);
        }

        //public List<Attraction> GetAllFavourites()
        //{
        //    return _favourites;
        //}

        //public void AddToAttractions(int id)
        //{
        //    if (_favourites == null)
        //    {
        //        _favourites = new List<Attraction>();
        //    }

        //    var attraction = FindAttractionById(id);

        //    _favourites.Add(attraction);

        //    if (_favourites != null)
        //    {
        //        //
        //    }
        //}

    }
}