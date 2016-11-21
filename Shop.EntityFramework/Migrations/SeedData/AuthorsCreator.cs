using Shop.Auhtors;
using Shop.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Migrations.SeedData
{
    public class AuthorsCreator : DefaultDataCreator<ShopDbContext>
    {
        public AuthorsCreator(ShopDbContext context) : base(context)
        {
        }

        protected override void CreateContent()
        {
            var authors = new List<Author>
            {
               new Author { Name = "Adam Mickiewicz" },
               new Author { Name = "Juliusz Słowacki" },
               new Author { Name = "Henryk Sienkiewicz" },
               new Author { Name = "Bolesław Prus" },
               new Author { Name = "Stefan Żeromski" },
               new Author { Name = "Jan Brzechwa" }
            };
            authors.ForEach(a => _context.Authors.Add(a));
            _context.SaveChanges();
        }
    }
}
