using PMS.Core.Domain;
using PMS.Core.Domain.Entities;
using PMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Persistence.Repositories
{
    public class PropertyRepository : Repository<Property>, IPropertyRepository
    {
        public PropertyRepository(PMSContext context) : base(context)
        {
        }

        //public Venture GetVentureWithProperties(int id)
        //{
        //    return PMSContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.Id == id);
        //}

        public PMSContext PMSContext
        {
            get { return Context as PMSContext; }
        }
    }
}
