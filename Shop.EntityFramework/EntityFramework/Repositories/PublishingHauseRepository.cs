using Shop.PublishingHauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;


namespace Shop.EntityFramework.Repositories
{
    public class PublishingHauseRepository : ShopRepositoryBase<PublishingHause>, IPublishingHauseRepository
    {
        public PublishingHauseRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<PublishingHause> GetAllPublishingHauses()
        {
            var query = GetAll().ToList();
            return query;
        }
    }
}
