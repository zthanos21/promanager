using ProManager.Entities.Base;
using ProManager.Entities.SystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.AgentAdmin
{
    public class Property : BaseTenantModel
    {
        public Property()
        {
            // Location = new Address();
            Amenities = new HashSet<PropertyAmenities>();
            Features = new HashSet<PropertyFeatures>();
            Categories = new HashSet<Agent_PropertyCategories>();
            Services = new HashSet<PropertyServiceType>();
        }
        [StringLength(20)]
        public string Code { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string MarketingName { get; set; }
        [StringLength(150)]
        public string RealName { get; set; }

        public Guid? AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Location { get; set; }

        public virtual ICollection<PropertyAmenities> Amenities { get; set; }
        public virtual ICollection<PropertyFeatures> Features { get; set; }
        public virtual ICollection<Agent_PropertyCategories> Categories { get; set; }
        public virtual ICollection<PropertyServiceType> Services { get; set; }
        public virtual ICollection<Layout> Layout { get; set; }

        public int Beds { get; set; }
        public int Bathrooms { get; set; }
        public int Showers { get; set; }
        public int Occupancy { get; set; }

        public decimal SurfaceArea { get; set; }

    }
}
