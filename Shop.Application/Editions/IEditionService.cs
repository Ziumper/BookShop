using Abp.Application.Services;
using Shop.Editions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Editions
{
    public interface IEditionService : IApplicationService
    {
        DefaultSearchOutput<EditionDto> GetAllEditions();
    }
}
