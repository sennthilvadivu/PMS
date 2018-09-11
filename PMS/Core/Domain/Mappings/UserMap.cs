using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Domain.Mappings
{    
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Table
            ToTable("User");

            // Key
            HasKey(data => data.ID);
                        
            // Fields
            Property(data => data.Name);
            Property(data => data.Email);
            Property(data => data.Phone);
            Property(data => data.Address);
            Property(data => data.HashedPassword);
            Property(data => data.SecurityQuestion);
            Property(data => data.SecurityAnswer);
            Property(data => data.IsCustomer);
            Property(data => data.IsLocked);
            Property(data => data.IsDeleted);
            Property(data => data.CreatedBy);
            Property(data => data.CreatedOn);
            Property(data => data.UpdatedBy);
            Property(data => data.UpdatedOn);
        }

    }
}
