using Abp.Application.Services;
using Shop.PublishingHauses.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.PublishingHauses
{
    public interface IPublishingHauseService : IApplicationService
    {
        DefaultSearchOutput<PublishingHauseDto> GetAllPublishingHauses();
    }
}
