using System;
using System.Collections.Generic;

namespace PMS.Core.Domain.Entities
{
    public partial class Role
    {        
        public Role()
        {
            this.ServiceAuthorizations = new HashSet<ServiceAuthorization>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public virtual ICollection<ServiceAuthorization> ServiceAuthorizations { get; set; }
    }
}
