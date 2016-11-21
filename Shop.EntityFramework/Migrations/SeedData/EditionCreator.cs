using Shop.Eidtions;
using Shop.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Migrations.SeedData
{
    class EditionCreator : DefaultDataCreator<ShopDbContext>
    {
        public EditionCreator(ShopDbContext context) : base(context)
        {
        }

        protected override void CreateContent()
        {
            var editions = new List<Edition>
            {
                new Edition { Release = DateTime.Parse("1992-05-01") },
                new Edition { Release = DateTime.Parse("1784-11-25") },
                new Edition { Release = DateTime.Parse("2015-08-24") },
                new Edition { Release = DateTime.Parse("2001-01-01") },
                new Edition { Release = DateTime.Parse("1863-12-24") },
                new Edition { Release = DateTime.Parse("1945-09-01") },
            };
            editions.ForEach(e => _context.Editions.Add(e));
            _context.SaveChanges();
        }
    }
}
