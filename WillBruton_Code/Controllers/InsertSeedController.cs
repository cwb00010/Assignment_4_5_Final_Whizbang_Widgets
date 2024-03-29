using Microsoft.AspNetCore.Mvc;
using FarmMaxSiteAPI.Entities;
using FarmMaxSiteAPI.Repositiories;

namespace FarmMaxSiteAPI.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class InsertSeedController : ControllerBase
    {
        private readonly ISeedService _InsertID;
        public InsertSeedController(ISeedService InsertID)
        {
            _InsertID = InsertID;
        }
        [HttpPost("{SeedID}")]
        public async Task<ActionResult<List<Seed>>> InsertID(int SeedID)
        {
            var insertID = await _InsertID.InsertID(SeedID);
            return insertID;


            {
        private readonly ISeedService _InsertName;
        public InsertSeedController(ISeedService InsertName)
        {
            _InsertName = InsertName;
        }
        [HttpPost("{SeedName}")]
        public async Task<ActionResult<List<Seed>>> InsertName(string SeedName)
        {
            var seed = await _InsertName.InsertName(SeedName);
            return seed;
        }

        [HttpPost]("{IdealTemp}"]
        private static async Task<ActionResult<string>> InsertIdealTemp(string IdealTemp)
        {
            var insertName = await IdealTemp.InsertIdealTemp(IdealTemp);
            return insertName;
        }
    }
}
