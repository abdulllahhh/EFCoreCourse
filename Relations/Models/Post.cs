using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models
{
    public class Post
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? TagId { get; set; }
        public bool isDeleted { get; set; }
        public virtual Tag? Tag { get; set; }
        public virtual ICollection<Tag>? Tags { get; set; }
        public virtual List<PostTag>? postTags { get; set; } // reference for the relation table
    }
}
