using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Shop.Eidtions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Editions.Dto
{
    [AutoMapFrom(typeof(Edition))]
    public class EditionDto : EntityDto
    {
        public DateTime Release { get; set; }
    }
}
