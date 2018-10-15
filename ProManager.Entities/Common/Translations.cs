using ProManager.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProManager.Entities.Common
{
    public class Translations : BaseTenantModel
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public Guid RowId { get; set; }
        public string Value { get; set; }
        public string LanguageCode { get; set; }
        public Guid? LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Languages Language { get; set; }
    }
}
