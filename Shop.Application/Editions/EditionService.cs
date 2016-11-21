using AutoMapper;
using Shop.Editions.Dto;
using Shop.Eidtions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Editions
{
    class EditionService : ShopAppServiceBase, IEditionService
    {
        private readonly IEditionRepository _editionRepository;
        //TO DO AutoMapper Instance config

        public EditionService(IEditionRepository editionRepository)
        {
            _editionRepository = editionRepository;
           
        }

        public DefaultSearchOutput<EditionDto> GetAllEditions()
        {
            var editions = _editionRepository.GetAllEditions();
            Mapper.Initialize(cfg => cfg.CreateMap<Edition, EditionDto>());
            return new DefaultSearchOutput<EditionDto>
            {
                Items = Mapper.Map<List<EditionDto>>(editions),
            };
        }
    }
}
