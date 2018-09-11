using System;
using System.Collections.Generic;

namespace PMS.Core.Domain.Entities
{
    public partial class Venture
    {
        public Venture()
        {
            this.Properties = new HashSet<Property>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}
