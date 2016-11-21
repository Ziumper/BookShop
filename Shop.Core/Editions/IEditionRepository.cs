using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Eidtions
{
    public interface IEditionRepository 
    {
        List<Edition> GetAllEditions();
    }
}
