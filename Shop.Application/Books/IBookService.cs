using Abp.Application.Services;
using Shop.Books.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Books
{
    public interface IBookService : IApplicationService
    {
        DefaultSearchOutput<BookDto> GetAllBooks();
        DefaultSearchOutput<BookDto> GetBooksByType(GetBooksByTypeInput input);

        DefaultSearchOutput<BookDto> GetNewBooks(GetBooksNewPreviewDays input);
        DefaultSearchOutput<BookDto> GetPreviewBooks(GetBooksNewPreviewDays input);

        DefaultSearchOutput<BookDto> GetSpecialOccasion();

        DefaultSearchOutput<BookDto> SearchForBooks(SearchBookInput input);
    }
}
