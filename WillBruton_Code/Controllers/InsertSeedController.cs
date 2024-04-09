using Microsoft.AspNetCore.Mvc;
using FarmMaxSiteAPI.Entities;
using FarmMaxSiteAPI.Repositiories;

namespace FarmMaxSiteAPI.Controllers
{
    [Route("api/[controller]")]
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

        }

        private readonly ISeedService _InsertName;
        public InsertNameController(ISeedService InsertName)
        {
            _InsertName = InsertName;
        }
        [HttpPost("{SeedName}")]
        public async Task<ActionResult<List<Seed>>> InsertName(string SeedName)
        {
            var seed = await _InsertName.InsertName(SeedName);
            return seed;
        }

        private readonly ISeedService _InsertIdealTemp;
        public InsertIdealTempController(ISeedService InsertName)
        {
            _InsertIdealTemp = InsertIdealTemp;

            [HttpPost("{IdealTemp}")]
            public static async Task<ActionResult<Seed>> InsertIdealTemp(string IdealTemp)
            {
                var IdealTemp = await _IdealTemp.InsertIdealTemp(IdealTemp);
                return Temp;
            }
        }
    } }

