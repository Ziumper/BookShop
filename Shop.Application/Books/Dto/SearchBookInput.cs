using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Books.Dto
{
    public class SearchBookInput
    {
        public int ContentId { get; set; }
        public string SearchText { get; set; }
    }
}
