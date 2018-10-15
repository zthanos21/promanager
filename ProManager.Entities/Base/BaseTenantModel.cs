using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.Base
{
    public class BaseTenantModel : BaseModel
    {
        public Guid TenantId { get; set; }

        [ForeignKey("TenantId")]
        public virtual Tenants Tenants { get; set; }
    }
}
