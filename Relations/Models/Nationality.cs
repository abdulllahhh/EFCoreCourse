using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models
{
    public class Nationality
    {
        public int NationalityId { get; set; }
        public string Name { get; set; }
        public virtual List<Author>? authors { get; set; }
    }
}
