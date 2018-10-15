using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.Common
{
    public class BusinessRoleMenus : BaseModel
    {
        public Guid? BusinessRoleId { get; set; }
        [ForeignKey("BusinessRoleId")]
        public virtual BusinessRoles BusinessRoles { get; set; }
        public Guid? MenuItemId { get; set; }
        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }
    }
}
