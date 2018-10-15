using System;
using System.ComponentModel.DataAnnotations;

namespace ProManager.Entities.Base
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? ApplicationUserId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
