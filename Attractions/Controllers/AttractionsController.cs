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

    public IEnumerable<Attraction> Get(bool featured = false)
    {
        var attractions = featured == false ? _repo.GetAllAttractions().ToList() : _repo.GetFeaturedAttractions().ToList();

        return attractions;
    }
  }
}
