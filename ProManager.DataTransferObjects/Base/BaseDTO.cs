using ProManager.Enumerators;
using System;

namespace ProManager.DataTransferObjects.Base
{

    public class BaseDTO<TEntity> : IDTOModel<TEntity> where TEntity : class
    {
        public BaseDTO()
        {
            DTOState = DTOState.Unmodified;
            Id = this.Id == null || this.Id == Guid.Empty ? Guid.NewGuid() : this.Id;
            ModifiedDate = null;
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Boolean? IsDeleted { get; set; }
        public Guid? ApplicationUserId { get; set; }
        public Byte[] RowVersion { get; set; }


        public DTOState DTOState { get; set; }

        public virtual TEntity ToModel()
        {
           TEntity entity =  Activator.CreateInstance<TEntity>();
            //Set Default Values
            Id = this.Id == null || this.Id == Guid.Empty ? Guid.NewGuid() : this.Id;


            return entity;
        }

        public virtual void UpdateModel(TEntity model)
        {
        }
    }
}
