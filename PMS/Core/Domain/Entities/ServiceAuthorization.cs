using System;

namespace PMS.Core.Domain.Entities
{    
    public partial class ServiceAuthorization
    {
        public int ID { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }    
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
