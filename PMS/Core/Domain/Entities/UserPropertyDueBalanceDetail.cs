
namespace PMS.Core.Domain.Entities
{
    public partial class UserPropertyDueBalanceDetail
    {
        public int ID { get; set; }
        public int UserPropertyRelationId { get; set; }
        public decimal? DueAmount { get; set; }
        public decimal? DueAmountDate { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public decimal? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public decimal? UpdatedOn { get; set; }    
        public virtual UserPropertyRelation UserPropertyRelation { get; set; }
    }
}
