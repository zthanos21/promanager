using Microsoft.EntityFrameworkCore;
using ProManager.Entities.Common;

namespace ProManager.Entities
{
    public partial class ProManagerContext : DbContext
    {
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<SystemRoles> SystemRoles { get; set; }
        public virtual DbSet<ApplicationModules> ApplicationModules { get; set; }
        public virtual DbSet<ApplicationModuleMenus> ApplicationModuleMenus { get; set; }
        public virtual DbSet<ApplicationModuleSystemRoles> ApplicationModuleSystemRoles { get; set; }
        public virtual DbSet<BusinessRoles> BusinessRoles { get; set; }
        public virtual DbSet<ApplicationUserBusinessRole> ApplicationUserBusinessRole { get; set; }
        public virtual DbSet<BusinessRoleMenus> BusinessRoleMenus { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Translations> Translations { get; set; }
        public virtual DbSet<MenuItemGroup> MenuItemGroup { get; set; }
    }
}
