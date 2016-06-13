using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attractions.Data
{
    public class MvcDemoRepository : IRepository
    {
        private MvcDemoContext _ctx;

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
    }
}