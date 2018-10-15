using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.Common
{
    public class MenuItem : BaseModel
    {
        public Guid? ParentId { get; set; }
        public short Level { get; set; }
        public short MenuItemType { get; set; }
        public String Value { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }

        public Guid? MenuItemGroupId { get; set; }
        [ForeignKey("MenuItemGroupId")]
        public virtual MenuItemGroup MenuItemGroup { get; set; }
    }
}
