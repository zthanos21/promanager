using ProManager.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace ProManager.Entities.Common
{
    public class Languages : BaseModel
    {
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(1500)]
        public string GlyphUrl { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}
