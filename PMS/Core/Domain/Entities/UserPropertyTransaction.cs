using System;

namespace PMS.Core.Domain.Entities
{
    public partial class UserPropertyTransaction
    {
        public int ID { get; set; }
        public int UserPropertyRelationId { get; set; }
        public decimal? AmountPaid { get; set; }
        public DateTime? AmountPaidOn { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }    
        public virtual UserPropertyRelation UserPropertyRelation { get; set; }
    }
}
