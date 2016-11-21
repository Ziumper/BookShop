using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Carriers
{
    public interface ICarrierRepository
    {
        List<Carrier> GetAllCarriers();
    }
}
