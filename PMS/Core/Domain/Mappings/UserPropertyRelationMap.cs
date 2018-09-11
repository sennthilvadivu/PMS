using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Domain.Mappings
{    
    public class UserPropertyRelationMap : EntityTypeConfiguration<UserPropertyRelation>
    {
        public UserPropertyRelationMap()
        {
            // Table
            ToTable("UserPropertyRelation");

            // Key
            HasKey(data => data.ID);

            // Fields
            Property(data => data.Name);
            Property(data => data.UserId);
            Property(data => data.PropertyId);
            Property(data => data.PurchaseDate);
            Property(data => data.IsDeleted);
            Property(data => data.CreatedBy);
            Property(data => data.CreatedOn);
            Property(data => data.UpdatedBy);
            Property(data => data.UpdatedOn);
        }

    }
}
