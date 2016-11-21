using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Shop.Carriers;

namespace Shop.EntityFramework.Repositories
{
    public class CarrierRepository : ShopRepositoryBase<Carrier>, ICarrierRepository
    {
        public CarrierRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<Carrier> GetAllCarriers()
        {
            var query = GetAllList();
            return query;
        }
    }
}
