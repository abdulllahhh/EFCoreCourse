using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Relations.Models;
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
            var minimum_nationality_Id = _context.Nationalities.ToList().MinBy(i => i.NationalityId);
            
            Console.WriteLine(minimum_nationality_Id.NationalityId);
            
            
        }
    }
}
