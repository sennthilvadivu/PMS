using PMS.Core;
using PMS.Core.Repositories;
using PMS.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PMSContext _context;

        public UnitOfWork(PMSContext context)
        {
            _context = context;
            //Courses = new CourseRepository(_context);
            //Authors = new AuthorRepository(_context);
            Properties = new PropertyRepository(_context);
            Ventures = new VentureRepository(_context);
        }

        public IPropertyRepository Properties { get; private set; }
        public IVentureRepository Ventures { get; private set; }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
