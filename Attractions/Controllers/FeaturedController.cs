using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Attractions.Data;

namespace Attractions.Controllers
{
  public class FeaturedController : ApiController
  {
    private readonly IRepository _repo;

    public FeaturedController(IRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Attraction> Get()
    {
        var attractions = _repo.GetFeaturedAttractions().ToList();

        return attractions;
    }
  }
}
