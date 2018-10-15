using ProManager.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProManager.DataTransferObjects.Base
{
    public class LanguagesDTO : BaseDTO<Languages>
    {
        public String Code { get; set; }
        public String GlyphUrl { get; set; }
        public String Description { get; set; }

        public override Languages ToModel()
        {
            // Create Model
            Languages model = base.ToModel();
            Code = this.Code;
            GlyphUrl = this.GlyphUrl;
            Description = this.Description;
            Id = this.Id;
            ModifiedDate = this.ModifiedDate;
            CreatedDate = this.CreatedDate;
            IsDeleted = this.IsDeleted.Value;
            ApplicationUserId = this.ApplicationUserId;
            RowVersion = this.RowVersion;

            return model;
        }

        public override void UpdateModel(Languages model)
        {
            model.Code = Code;
            model.GlyphUrl = GlyphUrl;
            model.Description = Description;
            model.Id = Id;
            model.ModifiedDate = ModifiedDate;
            model.IsDeleted = IsDeleted ?? false;
            model.ApplicationUserId = ApplicationUserId;
        }

    }
}
