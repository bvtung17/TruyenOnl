using System;
using TruyenOnl.Data.Entities;

namespace TruyenOnl.Models
{
    public class BookInCategory
    {
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
