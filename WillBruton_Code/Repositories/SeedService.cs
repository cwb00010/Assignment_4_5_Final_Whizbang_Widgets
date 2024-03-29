using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using FarmMaxSiteAPI.Data;
using FarmMaxSiteAPI.Entities;


namespace FarmMaxSiteAPI.Repositiories
{
    public class SeedService : ISeedService
    {
        private readonly DbContextClass _dbContextClass;
        public SeedService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Seed>> InsertID(int SeedID)
        {
            var param = new SqlParameter("@SeedID", SeedID);
            var SeedDetails = await Task.Run(() => _dbContextClass.Seed.FromSqlRaw("exec spInsertSeed @SeedID", param).ToListAsync());
            return SeedDetails;
        }

        public async Task<List<Seed>> InsertName(string SeedName)
        {
            var param = new SqlParameter("@SeedName", SeedName);
            var SeedDetails = await Task.Run(() => _dbContextClass.Seed.FromSqlRaw("exec spInsertSeed @SeedName", param).ToListAsync());
            return SeedDetails;
        }



        public async Task<List<Seed>> InsertPlantTemp(string IdealPlantTemp)
        {
            var param = new SqlParameter("@IdealPlantTemp", IdealPlantTemp);
            var SeedDetails = await Task.Run(() => _dbContextClass.Seed.FromSqlRaw("exec spInsertSeed @IdealPlantTemp", param).ToListAsync());
            return SeedDetails;
        }













    }
    }
