using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models
{
    public class Tag
    {
        public string? Id { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }
        public virtual List<PostTag>? postTags { get; set; } // reference for the relation table
    }
}
