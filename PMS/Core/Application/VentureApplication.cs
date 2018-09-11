using PMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Core.Common;
using PMS.Core.Domain;
using PMS.Persistence;
using PMS.Core.Domain.Entities;

namespace PMS.Core.Application
{
    public class VentureApplication : IVentureApplication
    {
        private readonly IVentureRepository _ventureRepository;

        public VentureApplication(IVentureRepository ventureRepository)
        {
            _ventureRepository = ventureRepository;
        }

        public async Task<PMSResponse<int>> CreateVenture(CreateVentureRequest createVentureRequest)
        {
            using (var unitOfWork = new UnitOfWork(new PMSContext()))
            {
                unitOfWork.Ventures.Add(new Venture
                {
                    Name = createVentureRequest.Name,
                    City = createVentureRequest.City,
                    IsDeleted = false,
                    Status = createVentureRequest.Status,
                    CreatedBy = "KS",
                    CreatedOn = DateTime.UtcNow,
                    Properties = null
                });

                await unitOfWork.Complete();
            }

            return ServiceResponse<int>.Instance.BuildResponse(ResponseCodes.VentureCreated, 1);
        }

        public async Task<PMSResponse<Venture>> UpdateVenture(UpdateVentureRequest updateVentureRequest)
        {
            using (var unitOfWork = new UnitOfWork(new PMSContext()))
            {
                unitOfWork.Ventures.Add(new Venture
                {
                    Name = updateVentureRequest.Name,
                    City = updateVentureRequest.City,
                    IsDeleted = false,
                    Status = updateVentureRequest.Status,
                    CreatedBy = "KS",
                    CreatedOn = DateTime.UtcNow,
                    Properties = null
                });

                await unitOfWork.Complete();
            }

            return ServiceResponse<Venture>.Instance.BuildResponse(ResponseCodes.VentureCreated, new Venture());
        }

        public async Task<PMSResponse<VentureReponse>> GetVentures(VentureRequest ventureRequest)
        {
            VentureReponse response = null;
            using (var unitOfWork = new UnitOfWork(new PMSContext()))
            {
                response.Venutures = unitOfWork.Ventures.GetAll();
                await unitOfWork.Complete();
            }

            return ServiceResponse<VentureReponse>.Instance.BuildResponse(ResponseCodes.VentureCreated, response);
        }

        public async Task<PMSResponse<Venture>> GetVenture(VentureRequest ventureRequest)
        {
            Venture venture = null;
            using (var unitOfWork = new UnitOfWork(new PMSContext()))
            {
                venture = unitOfWork.Ventures.Get(ventureRequest.VentureId);
                await unitOfWork.Complete();
            }
            return ServiceResponse<Venture>.Instance.BuildResponse(ResponseCodes.VentureCreated, venture);
        }

        public async Task<PMSResponse<VentureReponse>> GetVentures(string searchText, VentureRequest ventureRequest)
        {
            VentureReponse response = null;
            using (var unitOfWork = new UnitOfWork(new PMSContext()))
            {
                response.Venutures = unitOfWork.Ventures.GetAll();
                await unitOfWork.Complete();
            }

            return ServiceResponse<VentureReponse>.Instance.BuildResponse(ResponseCodes.VentureCreated, response);
        }

        public async Task<PMSResponse<IEnumerable<Venture>>> GetVentures(string searchText)
        {
            IEnumerable<Venture> ventures = null;
            using (var unitOfWork = new UnitOfWork(new PMSContext()))
            {
                ventures = unitOfWork.Ventures.GetAll();
                await unitOfWork.Complete();
            }
            return ServiceResponse<IEnumerable<Venture>>.Instance.BuildResponse(ResponseCodes.VentureCreated, ventures);
        }
        //public async Task<PMSResponse<IEnumerable<Venture>>> GetVentures()
        //{
        //    IEnumerable<Venture> ventures = null;
        //    using (var unitOfWork = new UnitOfWork(new PMSContext()))
        //    {
        //        ventures = unitOfWork.Ventures.GetAll();
        //        await unitOfWork.Complete();
        //    }
        //    return ServiceResponse<IEnumerable<Venture>>.Instance.BuildResponse(ResponseCodes.VentureCreated, ventures);
        //}

        //public async Task<PMSResponse<Venture>> GetVentures(int ventureId)
        //{
        //    Venture venture = null;
        //    using (var unitOfWork = new UnitOfWork(new PMSContext()))
        //    {
        //        venture = unitOfWork.Ventures.Get(ventureId);
        //        await unitOfWork.Complete();
        //    }
        //    return ServiceResponse<Venture>.Instance.BuildResponse(ResponseCodes.VentureCreated, venture);
        //}

        //public async Task<PMSResponse<IEnumerable<Venture>>> GetVentures(string searchText)
        //{
        //    IEnumerable<Venture> ventures = null;
        //    using (var unitOfWork = new UnitOfWork(new PMSContext()))
        //    {
        //        ventures = unitOfWork.Ventures.GetAll();
        //        await unitOfWork.Complete();
        //    }
        //    return ServiceResponse<IEnumerable<Venture>>.Instance.BuildResponse(ResponseCodes.VentureCreated, ventures);
        //}

    }
}
