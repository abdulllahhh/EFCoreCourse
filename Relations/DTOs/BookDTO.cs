using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.DTOs
{
    public class BookDTO
    {

        public int BookId { get; set; }   
        public string Name { get; set; }
        public string authorName { get; set; }
        /*
         create procedure [dbo].[prc_GetAllBooksWithAuthors]
         as
        select dbo.Books.BookId , dbo.Books.Name, dbo.Authors.Name as authorName
        from dbo.Books	inner join
            dbo.Authors
            on dbo.Books.AuthorId = dbo.Authors.AuthorId
         */
    }
}
