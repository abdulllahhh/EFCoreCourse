﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }
    }
}
