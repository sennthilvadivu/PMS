using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Domain.Mappings
{    
    public class PropertyMap : EntityTypeConfiguration<Property>
    {
        public PropertyMap()
        {
            // Table
            ToTable("Property");

            // Key
            HasKey(data => data.ID);

            // Fields
            Property(data => data.Name);
            Property(data => data.VentureId);
            Property(data => data.Status);
            Property(data => data.Unit);
            Property(data => data.UoM);
            Property(data => data.BasePrice);
            Property(data => data.CurrencyCode);            
            Property(data => data.IsDeleted);
            Property(data => data.CreatedBy);
            Property(data => data.CreatedOn);
            Property(data => data.UpdatedBy);
            Property(data => data.UpdatedOn);
        }

    }
}
