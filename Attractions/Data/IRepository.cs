using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attractions.Data
{
    public interface IRepository
    {
        IQueryable<Attraction> GetAllAttractions();

        IQueryable<Attraction> GetFeaturedAttractions();

        IQueryable<Attraction> FindAttractions(string searchText);

        IQueryable<Attraction> FindAttractionsInContinent(string continent);

        Attraction FindAttractionById(int id);

    }
}
