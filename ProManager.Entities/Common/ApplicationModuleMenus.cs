using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.Common
{
    public class ApplicationModuleMenus : BaseModel
    {
        public Guid? MenuItemId { get; set; }
        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }

        public Guid? ApplicationModulesId { get; set; }
        [ForeignKey("ApplicationModulesId")]
        public virtual ApplicationModules ApplicationModules { get; set; }
    }
}
