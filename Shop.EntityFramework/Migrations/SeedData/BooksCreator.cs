using Shop.Books;
using Shop.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Migrations.SeedData
{
    public class BooksCreator : DefaultDataCreator<ShopDbContext>
    {
        public BooksCreator(ShopDbContext context) : base(context)
        {
        }

        protected override void CreateContent()
        {
            var books = new List<Book>
            {
               new Book{Name = "Pan Tadeusz",ReleaseDate = DateTime.Parse("2000-04-25"),Price = 32.50,AuthorId = 1,PublishingHauseId = 1,SpecialOccasion = false,Type = 1},
               new Book{Name = "Dziady cz I", ReleaseDate = DateTime.Parse("2001-05-25"),Price = 42.20,AuthorId = 1,PublishingHauseId = 1, SpecialOccasion = false,Type = 1},
               new Book{Name = "Dziady cz II", ReleaseDate = DateTime.Parse("1925-05-25"),Price = 120.12,AuthorId = 1,PublishingHauseId = 1, SpecialOccasion = true,Type = 2},
               new Book{Name = "Wiersze", ReleaseDate = DateTime.Parse("2008-01-12"),Price = 60.10,AuthorId = 1,PublishingHauseId = 4, SpecialOccasion = true,Type = 2},
               new Book{Name = "Dziady cz II", ReleaseDate = DateTime.Parse("1925-08-21"),Price = 150.23,AuthorId = 1,PublishingHauseId = 3, SpecialOccasion = true,Type = 1},
               new Book{Name = "Anheli", ReleaseDate = DateTime.Parse("1841-05-11"),Price = 42,AuthorId = 2,PublishingHauseId = 2, SpecialOccasion = true,Type = 2},
               new Book{Name = "Dziady cz III", ReleaseDate = DateTime.Parse("2010-04-18"),Price = 420.10,AuthorId = 1,PublishingHauseId = 5, SpecialOccasion = true,Type = 1},
               new Book{Name = "Testament Mój", ReleaseDate = DateTime.Parse("2010-11-16"),Price = 39.99,AuthorId = 2,PublishingHauseId = 7, SpecialOccasion = true,Type = 1},
               new Book{Name = "Ojciec zadżumionych", ReleaseDate = DateTime.Parse("1993-01-27"),Price = 21,AuthorId = 2,PublishingHauseId =5, SpecialOccasion = false,Type = 1},
               new Book{Name = "Grób Agamemnona", ReleaseDate = DateTime.Parse("2016-11-01"),Price = 50,AuthorId = 2,PublishingHauseId = 5, SpecialOccasion = false,Type = 2},
               new Book{Name = "Quo Vadis", ReleaseDate = DateTime.Parse("2015-04-22"),Price = 122.70,AuthorId = 3,PublishingHauseId = 9, SpecialOccasion = true,Type = 1},
               new Book{Name = "Krzyżacy", ReleaseDate = DateTime.Parse("2004-08-18"),Price = 147,AuthorId = 3,PublishingHauseId = 8, SpecialOccasion = true,Type = 2},
               new Book{Name = "Potop", ReleaseDate = DateTime.Parse("2002-09-12"),Price = 50.44,AuthorId = 3,PublishingHauseId = 2, SpecialOccasion = true,Type = 2},
               new Book{Name = "Ogniem i Mieczem", ReleaseDate = DateTime.Parse("2004-08-18"),Price = 147,AuthorId = 3,PublishingHauseId = 9, SpecialOccasion = false,Type = 1},
               new Book{Name = "W pustyni i w puszczy", ReleaseDate = DateTime.Parse("2001-08-18"),Price = 50,AuthorId = 3,PublishingHauseId = 1, SpecialOccasion = true,Type = 2},
               new Book{Name = "Pan Wołodyjowski", ReleaseDate = DateTime.Parse("2016-11-17"),Price = 22,AuthorId = 3,PublishingHauseId = 8, SpecialOccasion = false,Type = 1},
               new Book{Name = "Przedwiośnie", ReleaseDate = DateTime.Parse("2016-11-13"),Price = 110.20,AuthorId = 5,PublishingHauseId = 2, SpecialOccasion = true,Type = 2},
               new Book{Name = "Ludzie Bezdomni", ReleaseDate = DateTime.Parse("2016-11-08"),Price = 147,AuthorId = 5,PublishingHauseId = 9, SpecialOccasion = true,Type = 1},
               new Book{Name = "Popioły", ReleaseDate = DateTime.Parse("2016-11-10"),Price = 47.20,AuthorId = 5,PublishingHauseId = 3, SpecialOccasion = false,Type = 1},
               new Book{Name = "Akademia Pana Kleksa", ReleaseDate = DateTime.Parse("2004-08-18"),Price = 20,AuthorId = 6,PublishingHauseId = 9, SpecialOccasion = true,Type = 2},

            };

            books.ForEach(b => _context.Books.Add(b));
            _context.SaveChanges();

        }
    }
}
