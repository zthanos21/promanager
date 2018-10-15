using ProManager.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace ProManager.Entities.SystemAdmin
{
    public class System_EmailTypes : BaseModel
    {
        [StringLength(30)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public short Weight { get; set; }
        public short Sort { get; set; }
    }
}
