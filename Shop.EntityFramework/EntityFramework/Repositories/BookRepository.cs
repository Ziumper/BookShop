using Shop.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using System.Data.Entity;

namespace Shop.EntityFramework.Repositories
{
    public class BookRepository : ShopRepositoryBase<Book, long>, IBookRepository
    {
        public BookRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<Book> GetAllBooks()
        {
            var query = GetAll().Include(book => book.Author).Include(book => book.PublishingHause).ToList();
            return query;
        }

        public List<Book> GetBooksByOccasion(bool SpecialOccasion)
        {
            var query = GetAll().Where(book => book.SpecialOccasion == SpecialOccasion).ToList();
            return query;
        }

        public List<Book> GetBooksByType(int Type)
        {
            var query = GetAll().Include(book => book.Author).Include(book => book.PublishingHause).Where(book => book.Type == Type).ToList();
            return query;
        }

        public List<Book> GetNewBooks(int amountOfDays)
        {
            var end = DateTime.Now;
            var begin = end.AddDays(-amountOfDays);
            var query = GetAll().Where(book => book.ReleaseDate >= begin && book.ReleaseDate <= end).ToList();
            return query;
        }

        public List<Book> GetPreviewBooks(int amountOfDays)
        {
            var begin = DateTime.Now;
            var end = begin.AddDays(amountOfDays);
            var query = GetAll().Where(book => book.ReleaseDate >= begin && book.ReleaseDate <= end).ToList();
            return query;
        }

        public List<Book> GetSearchBooks(int contentId, string searchText)
        {
            var query = new List<Book>();
            switch(contentId)
            {
                case 0: //All books
                    {
                        query = GetAllBooks().Where(book => book.Author.Name.StartsWith(searchText) || book.Name.StartsWith(searchText)).ToList();
                        break;
                    }

                case 1:
                    {
                        query = GetBooksByType(contentId).Where(book => book.Author.Name.StartsWith(searchText) || book.Name.StartsWith(searchText)).ToList();
                        break;
                    }
                case 2:
                    {
                        query = GetBooksByType(contentId).Where(book => book.Author.Name.StartsWith(searchText) || book.Name.StartsWith(searchText)).ToList();
                        break;
                    }
                case 3:
                    {
                        query = GetNewBooks(14).Where(book => book.Author.Name.StartsWith(searchText) || book.Name.StartsWith(searchText)).ToList();
                        break;
                    }
                case 4:
                    {
                        query = GetPreviewBooks(14).Where(book => book.Author.Name.StartsWith(searchText) || book.Name.StartsWith(searchText)).ToList();
                        break;
                    }
                case 5:
                    {
                        query = GetBooksByOccasion(true).Where(book => book.Author.Name.StartsWith(searchText) || book.Name.StartsWith(searchText)).ToList();
                        break;
                    }
               
            }
            return query;
        }
    }
}
