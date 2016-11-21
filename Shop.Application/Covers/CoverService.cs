using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Covers.Dto;
using AutoMapper;

namespace Shop.Covers
{
    public class CoverService : ShopAppServiceBase, ICoverService
    {
        private readonly ICoverRepository _coverRepository;

        public CoverService(ICoverRepository coverRepository)
        {
            _coverRepository = coverRepository;
            
        }

        public DefaultSearchOutput<CoverDto> GetAllCovers()
        {
            var covers = _coverRepository.GetAllCovers();

            Mapper.Initialize(cfg => cfg.CreateMap<Cover, CoverDto>());
            return new DefaultSearchOutput<CoverDto>
            {
                Items = Mapper.Map<List<CoverDto>>(covers),
            };
        }
    }
}
