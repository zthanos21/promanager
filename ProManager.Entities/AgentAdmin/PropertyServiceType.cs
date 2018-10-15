using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.AgentAdmin
{
    public class PropertyServiceType : BaseTenantModel
    {
        public Guid AgentServiceTypeId { get; set; }
        public Guid PropertyId { get; set; }

        [ForeignKey("AgentServiceTypeId")]
        public virtual Agent_ServiceType Agent_ServiceType { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }
    }
}
