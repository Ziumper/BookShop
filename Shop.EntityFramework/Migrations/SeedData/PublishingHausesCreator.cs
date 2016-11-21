using Shop.EntityFramework;
using Shop.PublishingHauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Migrations.SeedData
{
    public class PublishingHausesCreator : DefaultDataCreator<ShopDbContext>
    {
        public PublishingHausesCreator(ShopDbContext context) : base(context)
        {
        }

        protected override void CreateContent()
        {
            var publHauses = new List<PublishingHause>
            {
                new PublishingHause { Name = "ABE Dom Wydawniczy" },
                new PublishingHause { Name = "Kurtiak i Ley" },
                new PublishingHause { Name = "Jeden Świat" },
                new PublishingHause { Name = "IFC Press" },
                new PublishingHause { Name = "Gdańskie Wydawnictwo Oświatowe" },
                new PublishingHause { Name = "Egros" },
                new PublishingHause { Name = "Dekorgraf " },
                new PublishingHause { Name = "Difin Wydawnictwo" },
                new PublishingHause { Name = "Biały Kruk" }
            };

            publHauses.ForEach(p => _context.PublishingHauses.Add(p));
            _context.SaveChanges();
        }
    }
}
