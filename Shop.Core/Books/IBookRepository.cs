using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Books
{
    public interface IBookRepository : IRepository<Book,long>
    {
        List<Book> GetAllBooks();
        List<Book> GetBooksByOccasion(bool SpecialOccasion);
        List<Book> GetBooksByType(int Type);
        List<Book> GetNewBooks(int amountOfDays);
        List<Book> GetPreviewBooks(int amountOfDays);
        List<Book> GetSearchBooks(int contentId, string searchText);
    }
}
