using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Shop.PublishingHauses.Dto;
using AutoMapper;

namespace Shop.PublishingHauses
{
    public class PublishingHauseService : ShopAppServiceBase, IPublishingHauseService
    {
        private readonly IPublishingHauseRepository _publishingHauseRepository;

        public PublishingHauseService(IPublishingHauseRepository publishingHauseRepository)
        {
            _publishingHauseRepository = publishingHauseRepository;
           
        }

        public DefaultSearchOutput<PublishingHauseDto> GetAllPublishingHauses()
        {
            var ph = _publishingHauseRepository.GetAllPublishingHauses();
            Mapper.Initialize(cfg => cfg.CreateMap<PublishingHause, PublishingHauseDto>());
            return new DefaultSearchOutput<PublishingHauseDto>
            {
                Items = Mapper.Map<List<PublishingHauseDto>>(ph),
            };
        }
    }
}
