using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmMaxSiteAPI.Entities
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        public int CityID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FarmType { get; set; }

    }
}
