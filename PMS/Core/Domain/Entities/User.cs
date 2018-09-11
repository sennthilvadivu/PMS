using System;
using System.Collections.Generic;

namespace PMS.Core.Domain.Entities
{


    public partial class User
    {
        public User()
        {
            this.ServiceAuthorizations = new HashSet<ServiceAuthorization>();
            this.UserPropertyRelations = new HashSet<UserPropertyRelation>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string HashedPassword { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public bool? IsCustomer { get; set; }
        public bool? IsLocked { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public virtual ICollection<ServiceAuthorization> ServiceAuthorizations { get; set; }
        public virtual ICollection<UserPropertyRelation> UserPropertyRelations { get; set; }
    }
}
