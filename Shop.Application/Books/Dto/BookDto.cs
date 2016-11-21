using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Books.Dto
{
    [AutoMapFrom(typeof(Book))]
    public class BookDto : EntityDto<long>
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }

        public string AuthorName { get; set; }

        public string PublishingHauseName { get; set; }

    }
}
