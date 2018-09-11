using System;
using System.Collections.Generic;

namespace PMS.Core.Domain.Entities
{
    public partial class Property
    {        
        public Property()
        {
            this.UserPropertyRelations = new HashSet<UserPropertyRelation>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int VentureId { get; set; }
        public string Status { get; set; }
        public decimal? Unit { get; set; }
        public string UoM { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? BasePrice { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }    
        public virtual Venture Venture { get; set; }       
        public virtual ICollection<UserPropertyRelation> UserPropertyRelations { get; set; }
    }
}
