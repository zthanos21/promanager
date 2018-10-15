using ProManager.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProManager.Entities.Common
{
    public class MenuItemGroup : BaseModel
    {
        [StringLength(20)]
        public string Code { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public int Sort { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
