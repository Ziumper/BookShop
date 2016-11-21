using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Covers.Dto
{
    [AutoMapFrom(typeof(Cover))]
    public class CoverDto : EntityDto
    {
        public string Name { get; set; }
    }
}
