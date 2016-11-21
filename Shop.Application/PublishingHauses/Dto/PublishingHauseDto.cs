using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Shop.PublishingHauses.Dto
{
    [AutoMapFrom(typeof(PublishingHause))]
    public class PublishingHauseDto : EntityDto
    {
        public string Name { get; set; }
    }
}