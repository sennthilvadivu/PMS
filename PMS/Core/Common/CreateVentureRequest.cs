using PMS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Common
{
    public class CreateVentureRequest
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Status { get; set; }

    }

    public class UpdateVentureRequest
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
    }

    public class VentureRequest
    {
        public int VentureId { get; set; }
        public SortOrder SortingOrder { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

    }

    public class VentureReponse
    {
        public VentureReponse()
        {
            Venutures = new List<Venture>();
        }
        public int Count { get; set; }
        public IEnumerable<Venture> Venutures { get; set; }
    }

    public enum SortOrder
    {
        asc,
        desc
    }
}
