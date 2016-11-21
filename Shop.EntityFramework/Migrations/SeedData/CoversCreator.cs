using Shop.Covers;
using Shop.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Migrations.SeedData
{
    public class CoversCreator : DefaultDataCreator<ShopDbContext>
    {
        public CoversCreator(ShopDbContext context) : base(context)
        {
        }

        protected override void CreateContent()
        {
            var covers = new List<Cover>
            {
                new Cover { Name = "Tekstowa" },
                new Cover { Name = "Czarno-Biała" },
                new Cover { Name = "Kolorowa" },
            };
           
            covers.ForEach(a => _context.Covers.Add(a));
            _context.SaveChanges();
        }
    }
    
}
