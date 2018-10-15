using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.Common
{
    public class ApplicationModuleSystemRoles : BaseModel
    {
        public Guid? ApplicationModulesId { get; set; }
        [ForeignKey("ApplicationModulesId")]
        public ApplicationModules ApplicationModules { get; set; }

        public Guid? SystemRolesId { get; set; }
        [ForeignKey("SystemRolesId")]
        public SystemRoles SystemRoles { get; set; }
    }
}
