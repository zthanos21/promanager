using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.AgentAdmin
{
    public class PropertyFeatures : BaseTenantModel
    {
        public Guid AgentFeaturesId { get; set; }
        public Guid PropertyId { get; set; }

        [ForeignKey("AgentFeaturesId")]
        public virtual Agent_Features Agent_Features { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }
    }
}
