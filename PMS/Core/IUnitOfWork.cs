using PMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core
{
    public interface IUnitOfWork : IDisposable
    {       
        IVentureRepository Ventures { get; }
        IPropertyRepository Properties { get; }

        Task<int> Complete();
    }
}
