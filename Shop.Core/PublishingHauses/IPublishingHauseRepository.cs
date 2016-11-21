using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.PublishingHauses
{
    public interface IPublishingHauseRepository 
    {
        List<PublishingHause> GetAllPublishingHauses();
    }
}
