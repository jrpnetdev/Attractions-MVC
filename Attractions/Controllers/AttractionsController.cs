using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Attractions.Data;

namespace Attractions.Controllers
{
    public class AttractionsController : ApiController
    {
        private readonly IRepository _repo;

        public AttractionsController(IRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Attraction> Get()
        {
            var attractions = _repo.GetAllAttractions().ToList();

            return attractions;
        }

        public IEnumerable<Attraction> Get(string searchText)
        {
            var attractions = String.IsNullOrWhiteSpace(searchText) ? _repo.GetAllAttractions().ToList() : _repo.FindAttractions(searchText).ToList();

            return attractions;
        }
    }
}
