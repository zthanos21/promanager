using ProManager.Entities.Base;
using ProManager.Entities.SystemAdmin;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.AgentAdmin
{
    public class Agent_PropertyCategories : BaseTenantModel
    {
        [StringLength(30)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public short Weight { get; set; }
        public short Sort { get; set; }

        public Guid? SystemPropertyCategoriesId { get; set; }

        [ForeignKey("SystemPropertyCategoriesId")]
        public virtual System_PropertyCategories System_PropertyCategories { get; set; }
    }
}
