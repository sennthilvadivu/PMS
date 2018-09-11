using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Domain.Mappings
{    
    public class UserPropertyDueBalanceDetailMap : EntityTypeConfiguration<UserPropertyDueBalanceDetail>
    {
        public UserPropertyDueBalanceDetailMap()
        {
            // Table
            ToTable("UserPropertyDueBalanceDetail");
            // Key
            HasKey(data => data.ID);

            // Fields
            Property(data => data.UserPropertyRelationId);
            Property(data => data.DueAmount);
            Property(data => data.DueAmountDate);
            Property(data => data.IsDeleted);
            Property(data => data.CreatedBy);
            Property(data => data.CreatedOn);
            Property(data => data.UpdatedBy);
            Property(data => data.UpdatedOn);
        }

    }
}
