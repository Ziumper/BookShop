using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Shop.Eidtions;

namespace Shop.EntityFramework.Repositories
{
    public class EditionRepository : ShopRepositoryBase<Edition>, IEditionRepository
    {
        public EditionRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<Edition> GetAllEditions()
        {
            var query = GetAllList();
            return query;
        }
    }
}
