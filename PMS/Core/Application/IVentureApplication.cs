using PMS.Core.Common;
using PMS.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PMS.Core.Application
{
    public interface IVentureApplication
    {
        Task<PMSResponse<int>> CreateVenture(CreateVentureRequest createVentureRequest);
        Task<PMSResponse<Venture>> UpdateVenture(UpdateVentureRequest updateVentureRequest);
        Task<PMSResponse<VentureReponse>> GetVentures(VentureRequest ventureRequest);
        Task<PMSResponse<Venture>> GetVenture(VentureRequest ventureRequest);
        Task<PMSResponse<VentureReponse>> GetVentures(string searchText, VentureRequest ventureRequest);

    }
}
