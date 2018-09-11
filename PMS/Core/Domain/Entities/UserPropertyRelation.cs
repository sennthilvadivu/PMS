using System;
using System.Collections.Generic;

namespace PMS.Core.Domain.Entities
{
    public partial class UserPropertyRelation
    {
 
        public UserPropertyRelation()
        {
            this.UserPropertyDueBalanceDetails = new HashSet<UserPropertyDueBalanceDetail>();
            this.UserPropertyTransactions = new HashSet<UserPropertyTransaction>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int PropertyId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public virtual Property Property { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserPropertyDueBalanceDetail> UserPropertyDueBalanceDetails { get; set; }
        public virtual ICollection<UserPropertyTransaction> UserPropertyTransactions { get; set; }
    }
}
