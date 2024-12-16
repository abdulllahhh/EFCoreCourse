using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models
{
    //[Index("Tag")]
    public class PostTag
    {
        public virtual Post? post { get; set; } // navigation property
        public virtual Tag? Tag { get; set; } // navigation property
        public string? tagId { get; set; }
        public string? postId { get; set; }
        public DateTime AddedOn { get; set; }


    }
}
