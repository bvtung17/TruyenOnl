using System;
using TruyenOnl.Data.Entities;

namespace TruyenOnl.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int STT { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public Book Book { get; set; }

    }
}
