using PMS.Core.Domain;
using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Repositories
{

    public interface IVentureRepository : IRepository<Venture>
    {
        //Venture GetVentureWithProperties(int id);
    }


    
}
