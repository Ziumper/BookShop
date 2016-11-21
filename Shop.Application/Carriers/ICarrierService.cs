using Abp.Application.Services;
using Shop.Carriers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Carriers
{
    public interface ICarrierService : IApplicationService
    {
        DefaultSearchOutput<CarrierDto> GetAllCarriers();
    }
}
