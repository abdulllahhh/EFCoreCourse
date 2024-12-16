using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using static Relations.ApplicationDbContext;
namespace Relations
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var books = _context.BookDTO.FromSqlRaw($"prc_GetAllBooksWithAuthors").ToList();
            foreach (var book in books)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}
