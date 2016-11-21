using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Shop.Covers;

namespace Shop.EntityFramework.Repositories
{
    public class CoverRepository : ShopRepositoryBase<Cover>, ICoverRepository
    {
        public CoverRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<Cover> GetAllCovers()
        {
            var query = GetAllList();
            return query;
        }
    }
}
