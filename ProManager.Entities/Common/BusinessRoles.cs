using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProManager.Entities.Common
{
    public class BusinessRoles : BaseModel
    {
        [StringLength(80)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public Int16 Type { get; set; }
    }
}
