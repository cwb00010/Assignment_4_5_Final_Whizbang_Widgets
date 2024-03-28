using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmSite2API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FarmType { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
