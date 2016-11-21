using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Carriers.Dto;
using AutoMapper;

namespace Shop.Carriers
{
    public class CarrierService : ShopAppServiceBase, ICarrierService
    {
        private readonly ICarrierRepository _carrierRepository;

        public CarrierService(ICarrierRepository carrierRepository)
        {
            _carrierRepository = carrierRepository;
           
        }

        public DefaultSearchOutput<CarrierDto> GetAllCarriers()
        {
            var carriers = _carrierRepository.GetAllCarriers();
            Mapper.Initialize(cfg => cfg.CreateMap<Carrier, CarrierDto>());
            return new DefaultSearchOutput<CarrierDto>
            {
                Items = Mapper.Map<List<CarrierDto>>(carriers)
            };
        }
    }
}
