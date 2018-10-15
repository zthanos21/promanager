using Microsoft.EntityFrameworkCore;
using ProManager.Entities.AgentAdmin;

namespace ProManager.Entities
{
    public partial class ProManagerContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Agent_Amenities> Agent_Amenities { get; set; }
        public virtual DbSet<Agent_Features> Agent_Features { get; set; }
        public virtual DbSet<Agent_PropertyCategories> Agent_PropertyCategories { get; set; }
        public virtual DbSet<Agent_ServiceType> Agent_ServiceType { get; set; }
        public virtual DbSet<GeoLocation> GeoLocation { get; set; }
        public virtual DbSet<Layout> Layout { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyAmenities> PropertyAmenities { get; set; }
        public virtual DbSet<PropertyFeatures> PropertyFeatures { get; set; }
        public virtual DbSet<PropertyServiceType> PropertyServiceType { get; set; }
        public virtual DbSet<RoomTypes> RoomTypes { get; set; }
    }
}
