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

        Attraction FindAttractionById(int id);

        //List<Attraction> GetAllFavourites();

        //void AddToAttractions(int id);

        //void RemoveFromFavourites();
    }
}
