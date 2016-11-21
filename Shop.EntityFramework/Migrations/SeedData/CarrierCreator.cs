using Shop.Carriers;
using Shop.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Migrations.SeedData
{
    public class CarrierCreator : DefaultDataCreator<ShopDbContext>
    {
        public CarrierCreator(ShopDbContext context) : base(context)
        {
        }

        protected override void CreateContent()
        {
            var carriers = new List<Carrier>
            {
                new Carrier { Name = "CD" },
                new Carrier { Name = "DVD" },
                new Carrier { Name = "Blue-Ray" },
                new Carrier { Name = "Pendrive" }
            };

            carriers.ForEach(c => _context.Carriers.Add(c));
            _context.SaveChanges();
        }
    }
}
