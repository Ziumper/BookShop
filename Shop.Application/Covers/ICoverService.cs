using Abp.Application.Services;
using Shop.Covers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Covers
{
    public interface ICoverService : IApplicationService
    {
        DefaultSearchOutput<CoverDto> GetAllCovers();
    }
}
