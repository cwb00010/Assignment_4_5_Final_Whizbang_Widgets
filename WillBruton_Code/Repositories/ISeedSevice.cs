using System.Threading.Tasks;
using FarmMaxSiteAPI.Entities;



namespace FarmMaxSiteAPI.Repositiories
{
    public interface ISeedService
    {
    
      
        public Task<List<Seed>> InsertID(int SeedID);
        public Task<List<Seed>> InsertName(string SeedName);
        public Task<List<Seed>> InsertTemp(string IdealPlantTemp);
    }
}

