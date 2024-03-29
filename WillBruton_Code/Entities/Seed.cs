using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmMaxSiteAPI.Entities
{
    public class Seed
    {
        public int SeedID { get; set; }

        [Required]
        public string SeedName { get; set; }

        [Required]  
        public string IdealPlantTemp { get; set; }

    }
}
