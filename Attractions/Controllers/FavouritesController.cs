using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Attractions.Data;

namespace Attractions.Controllers
{
    public class FavouritesController : ApiController
    {

        private static List<Attraction> _favourites;

        private readonly IRepository _repo;

        public FavouritesController(IRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Attraction> Get()
        {
            return _favourites;
        }

        [HttpPost]
        public IHttpActionResult Add(int id)
        {
            if (_favourites == null)
            {
                _favourites = new List<Attraction>();
            }

            var attraction = _repo.FindAttractionById(id);

            if (attraction == null)
            {
                return BadRequest();
            }

            if (_favourites.Contains(_favourites.SingleOrDefault(f => f.Id == id)))
            {
                return Ok();
            }

            _favourites.Add(attraction);

            return Ok();
        }

        public HttpResponseMessage Delete(int id)
        {
            var attraction = _repo.FindAttractionById(id);
            if (attraction == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _favourites.Remove(_favourites.SingleOrDefault(f => f.Id == id));
            
            var response = new HttpResponseMessage();
            response.Headers.Add("DeleteMessage", "Successfully Deleted!");
            return response;
        }
    }
}
