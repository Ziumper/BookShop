using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Books.Dto;
using AutoMapper;

namespace Shop.Books
{
    public class BookService : ShopAppServiceBase, IBookService
    {
        private readonly IBookRepository _bookRepository;
        

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            
        }

        public DefaultSearchOutput<BookDto> GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            Logger.Info("Geting all books");
            Mapper.Initialize(cfg => cfg.CreateMap<Book, BookDto>());
            return new DefaultSearchOutput<BookDto> {
                Items = Mapper.Map<List<BookDto>>(books),
            };
        }

        public DefaultSearchOutput<BookDto> GetBooksByType(GetBooksByTypeInput input)
        {
            var books = _bookRepository.GetBooksByType(input.Type);
            Logger.Info("Geting all books by type" + input.Type);
            Mapper.Initialize(cfg => cfg.CreateMap<Book, BookDto>());
            return new DefaultSearchOutput<BookDto>
            {
                Items = Mapper.Map<List<BookDto>>(books),
            };
        }

        public DefaultSearchOutput<BookDto> GetNewBooks(GetBooksNewPreviewDays input)
        {
            var books = _bookRepository.GetNewBooks(input.AmountOfDays);
            Mapper.Initialize(cfg => cfg.CreateMap<Book, BookDto>());
            return new DefaultSearchOutput<BookDto>
            {
                Items = Mapper.Map<List<BookDto>>(books),
            };
        }

        public DefaultSearchOutput<BookDto> GetPreviewBooks(GetBooksNewPreviewDays input)
        {
            var books = _bookRepository.GetPreviewBooks(input.AmountOfDays);
            Mapper.Initialize(cfg => cfg.CreateMap<Book, BookDto>());
            return new DefaultSearchOutput<BookDto>
            {
                Items = Mapper.Map<List<BookDto>>(books),
            };
        }

        public DefaultSearchOutput<BookDto> GetSpecialOccasion()
        {
            var books = _bookRepository.GetBooksByOccasion(true);
            Mapper.Initialize(cfg => cfg.CreateMap<Book, BookDto>());
            return new DefaultSearchOutput<BookDto>
            {
                Items = Mapper.Map<List<BookDto>>(books),
            };
        }

        public DefaultSearchOutput<BookDto> SearchForBooks(SearchBookInput input)
        {
            var books = _bookRepository.GetSearchBooks(input.ContentId, input.SearchText);
            Mapper.Initialize(cfg => cfg.CreateMap<Book, BookDto>());
            return new DefaultSearchOutput<BookDto>
            {
                Items = Mapper.Map<List<BookDto>>(books),
            };
        }
    
    }
}
