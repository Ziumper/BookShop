using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Carriers.Dto
{
    [AutoMapFrom(typeof(Carrier))]
    public class CarrierDto : EntityDto
    {
        public string Name { get; set; }
    }
}
