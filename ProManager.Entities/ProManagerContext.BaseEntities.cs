using Microsoft.EntityFrameworkCore;
using ProManager.Entities.Base;

namespace ProManager.Entities
{
    public partial class ProManagerContext : DbContext
    {
        public ProManagerContext(DbContextOptions<ProManagerContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Tenants> Tenants { get; set; }

        //public virtual DbSet<MenuItem> MenuItems { get; set; }
        //public virtual DbSet<SystemRoles> SystemRoles { get; set; }
        //public virtual DbSet<ApplicationModules> ApplicationModules { get; set; }
        //public virtual DbSet<ApplicationModuleMenus> ApplicationModuleMenus { get; set; }
        //public virtual DbSet<ApplicationModuleSystemRoles> ApplicationModuleSystemRoles { get; set; }
        //public virtual DbSet<BusinessRoles> BusinessRoles { get; set; }
        //public virtual DbSet<ApplicationUserBusinessRole> ApplicationUserBusinessRole { get; set; }
        //public virtual DbSet<BusinessRoleMenus> BusinessRoleMenus { get; set; }
        //public virtual DbSet<Languages> Languages { get; set; }
        //public virtual DbSet<Translations> Translations { get; set; }
        //public virtual DbSet<MenuItemGroup> MenuItemGroup { get; set; }
        //SystemAdmin
        //public virtual DbSet<System_Amenities> System_Amenities { get; set; }
        //public virtual DbSet<System_Features> System_Features { get; set; }
        //public virtual DbSet<System_PropertyCategories> System_PropertyCategories { get; set; }
        //public virtual DbSet<System_ServiceType> System_ServiceType { get; set; }
        //public virtual DbSet<System_EmailTypes> System_EmailTypes { get; set; }
        //Agent
        //public virtual DbSet<Address> Address { get; set; }
        //public virtual DbSet<Agent_Amenities> Agent_Amenities { get; set; }
        //public virtual DbSet<Agent_Features> Agent_Features { get; set; }
        //public virtual DbSet<Agent_PropertyCategories> Agent_PropertyCategories { get; set; }
        //public virtual DbSet<Agent_ServiceType> Agent_ServiceType { get; set; }
        //public virtual DbSet<GeoLocation> GeoLocation { get; set; }
        //public virtual DbSet<Layout> Layout { get; set; }
        //public virtual DbSet<Property> Property { get; set; }
        //public virtual DbSet<PropertyAmenities> PropertyAmenities { get; set; }
        //public virtual DbSet<PropertyFeatures> PropertyFeatures { get; set; }
        //public virtual DbSet<PropertyServiceType> PropertyServiceType { get; set; }
        //public virtual DbSet<RoomTypes> RoomTypes { get; set; }

        
    }
}
