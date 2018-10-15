using System.ComponentModel.DataAnnotations;

namespace ProManager.Entities.AgentAdmin
{
    public class Address : GeoLocation
    {
        [StringLength(20)]
        public string Code { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(200)]
        public string Street { get; set; }
        [StringLength(200)]
        public string StreetNumber { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string Region { get; set; }
        [StringLength(50)]
        public string ZipCode { get; set; }
        [StringLength(100)]
        public string CountryISOCode { get; set; }

    }
}