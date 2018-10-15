using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.Common
{
    public class ApplicationUserBusinessRole : BaseModel
    {
        public Guid? AspNetUserId { get; set; }
        public Guid? BusinessRoleId { get; set; }
        [ForeignKey("BusinessRoleId")]
        public virtual BusinessRoles BusinessRoles { get; set; }
    }
}
