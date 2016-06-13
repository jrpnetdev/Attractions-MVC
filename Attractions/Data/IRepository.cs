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

        //void AddToFavourites();

        //void RemoveFromFavourites();
    }
}
