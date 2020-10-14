using System;
using System.Collections.Generic;
using TruyenOnl.Data.Entities;

namespace TruyenOnl.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookInCategory> BookInCategories { get; set; }

    }
}
