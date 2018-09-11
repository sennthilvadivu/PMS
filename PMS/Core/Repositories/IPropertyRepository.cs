using PMS.Core.Domain;
using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Repositories
{  
    public interface IPropertyRepository : IRepository<Property>
    {
        //IEnumerable<Property> GetTopSellingProperties(int count);
        //IEnumerable<Property> GetPropertyWithVenture(int pageIndex, int pageSize);
    }
}
