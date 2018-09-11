using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PMS.Core.Application;
using PMS.Core.Common;

namespace PMS.API.Controllers
{
    public class VentureController : BaseController
    {
        private readonly IVentureApplication _ventureApplication;

        public VentureController(IVentureApplication ventureApplication)
        {
            _ventureApplication = ventureApplication;
        }


        [HttpPost]
        [ResponseType(typeof(PMSResponse<int>))]
        public async Task<HttpResponseMessage> CreateVenture(CreateVentureRequest createVentureRequest)
        {
            return BuildResponse(await _ventureApplication.CreateVenture(createVentureRequest));
        }

        [HttpPut]
        [ResponseType(typeof(PMSResponse<int>))]
        public async Task<HttpResponseMessage> UpdateVenture(CreateVentureRequest createVentureRequest)
        {
            return BuildResponse(await _ventureApplication.CreateVenture(createVentureRequest));
        }

        [HttpGet]
        [ResponseType(typeof(PMSResponse<VentureReponse>))]
        public async Task<HttpResponseMessage> GetVentures(VentureRequest ventureRequest)
        {
            return BuildResponse(await _ventureApplication.GetVentures(ventureRequest));
        }

        [HttpGet]
        [ResponseType(typeof(PMSResponse<VentureReponse>))]
        public async Task<HttpResponseMessage> GetVenture(VentureRequest ventureRequest)
        {
            return BuildResponse(await _ventureApplication.GetVenture(ventureRequest));
        }

        [HttpGet]
        [ResponseType(typeof(PMSResponse<VentureReponse>))]
        public async Task<HttpResponseMessage> GetVentures(string searchText, VentureRequest ventureRequest)
        {
            return BuildResponse(await _ventureApplication.GetVentures(searchText, ventureRequest));
        }
    }
}
