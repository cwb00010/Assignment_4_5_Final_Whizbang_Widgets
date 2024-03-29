using Microsoft.AspNetCore.Mvc;
using FarmMaxSiteAPI.Entities;
using FarmMaxSiteAPI.Repositiories;

namespace FarmMaxSiteAPI.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class GetUserDetailsByCityController : ControllerBase
    {
        private readonly IUserService _UserDetailsByCity;
        public GetUserDetailsByCityController(IUserService UserDetailsByCity)
        {
            _UserDetailsByCity = UserDetailsByCity;
        }
        [HttpGet("{CityID}")]
        public new async Task<ActionResult<List<UserDetails>>> User(int CityID)
        {
            var userDetails = await _UserDetailsByCity.InsertCityID(CityID);
            return userDetails;
        }
    }
}
