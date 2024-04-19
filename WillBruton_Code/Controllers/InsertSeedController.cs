using Microsoft.AspNetCore.Mvc;
using FarmMaxSiteAPI.Entities;
using FarmMaxSiteAPI.Repositiories;

namespace FarmMaxSiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertSeedController : ControllerBase
    {
        private readonly ISeedService _insertIDService;
        private readonly ISeedService _insertNameService;
        private readonly ISeedService _insertIdealTempService;

        public InsertSeedController(ISeedService insertIDService, ISeedService insertNameService, ISeedService insertIdealTempService)
        {
            _insertIDService = insertIDService;
            _insertNameService = insertNameService;
            _insertIdealTempService = insertIdealTempService;
        }

        [HttpPost("ID/{SeedID}")]
        public async Task<ActionResult<List<Seed>>> InsertID(int SeedID)
        {
            var insertID = await _insertIDService.InsertID(SeedID);
            return insertID;
        }

        [HttpPost("Name/{SeedName}")]
        public async Task<ActionResult<List<Seed>>> InsertName(string SeedName)
        {
            var seed = await _insertNameService.InsertName(SeedName);
            return seed;
        }

        [HttpPost("IdealTemp/{IdealTemp}")]
        public async Task<ActionResult<List<Seed>>> InsertTemp(string IdealTemp)
        {
            var IdealPlantTemp = await _insertIdealTempService.InsertTemp(IdealTemp);
            return IdealPlantTemp;
        }

    }
}
