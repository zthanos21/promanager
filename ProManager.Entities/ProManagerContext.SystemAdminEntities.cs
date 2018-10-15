using Microsoft.EntityFrameworkCore;
using ProManager.Entities.SystemAdmin;

namespace ProManager.Entities
{
    public partial class ProManagerContext : DbContext
    {
        public virtual DbSet<System_Amenities> System_Amenities { get; set; }
        public virtual DbSet<System_Features> System_Features { get; set; }
        public virtual DbSet<System_PropertyCategories> System_PropertyCategories { get; set; }
        public virtual DbSet<System_ServiceType> System_ServiceType { get; set; }
        public virtual DbSet<System_EmailTypes> System_EmailTypes { get; set; }
    }
}
