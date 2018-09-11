using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Domain.Mappings
{    
    public class ServiceAuthorizationMap : EntityTypeConfiguration<ServiceAuthorization>
    {
        public ServiceAuthorizationMap()
        {
            // Table
            ToTable("ServiceAuthorization");

            // Key
            HasKey(data => data.ID);

            // Fields
            Property(data => data.UserId);
            Property(data => data.RoleId);            
            Property(data => data.IsDeleted);
            Property(data => data.CreatedBy);
            Property(data => data.CreatedOn);
            Property(data => data.UpdatedBy);
            Property(data => data.UpdatedOn);
        }
    }
}
