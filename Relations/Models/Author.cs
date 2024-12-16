using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int NationalityId { get; set; }
        public virtual List<Book>? books { get; set; }
        public virtual Nationality nationality { get; set; }

    }
}
