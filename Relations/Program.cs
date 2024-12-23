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
            /*_context.Nationalities.Where(i => i.NationalityId < 20).ExecuteDelete();

            _context.Nationalities
                .Where(i => i.NationalityId > 1000)
                .ExecuteUpdate(x => x.SetProperty(n => n.Name , "eqyptinan"));*/
            
            /*_context.Nationalities
                .ExecuteUpdate(x => x.SetProperty(n => n.Name, n => n.Name + " updated"));*/
/*            _context.Nationalities.ExecuteUpdate(x => x.SetProperty(n => n.Name, n => n.Name.Replace("updated", "")));
*/            
        }
    }
}
