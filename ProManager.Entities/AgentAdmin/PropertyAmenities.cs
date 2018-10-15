using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.AgentAdmin
{
    public class PropertyAmenities : BaseTenantModel
    {
        public Guid AgentAmenitiesId { get; set; }
        public Guid PropertyId { get; set; }

        [ForeignKey("AgentAmenitiesId")]
        public virtual Agent_Amenities Agent_Amenities { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }
    }

}
