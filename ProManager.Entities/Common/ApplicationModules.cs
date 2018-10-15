using ProManager.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace ProManager.Entities.Common
{
    public class ApplicationModules : BaseModel
    {
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(300)]
        public string DefaultState { get; set; }
        public int Sort { get; set; }
    }
}
