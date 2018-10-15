using ProManager.Entities.Base;
using ProManager.Entities.SystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.AgentAdmin
{

    public class Layout : BaseTenantModel
    {
        public Layout()
        {
            RoomTypes = new HashSet<RoomTypes>();
        }
        ICollection<RoomTypes> RoomTypes { get; set; }
        /// <summary>
        /// Κάτοψη
        /// </summary>
        public string FloorPlanUri { get; set; }
        /// <summary>
        /// Εμβαδόν σε τμ
        /// </summary>
        public decimal SurfaceArea { get; set; }
        /// <summary>
        /// Όροφος
        /// </summary>
        public int Level { get; set; }

        public Guid PropertyId { get; set; }

        [ForeignKey("PropertyId")]
        public virtual Property Property { get; set; }
    }
}
