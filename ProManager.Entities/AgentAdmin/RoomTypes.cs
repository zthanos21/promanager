using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProManager.Entities.AgentAdmin
{
    /// <summary>
    /// Τύποι δωματίων Σαλόνι, Μπάνιο, Κουζίνα κλπ
    /// </summary>
    public class RoomTypes : BaseTenantModel
    {
        public Guid LayoutId { get; set; }
        public string Code { get; set; }
        public int Beds { get; set; }
        public string Description { get; set; }
        public int Occupancy { get; set; }
        [ForeignKey("LayoutId")]
        public virtual Layout Layout { get; set; }
    }
}
