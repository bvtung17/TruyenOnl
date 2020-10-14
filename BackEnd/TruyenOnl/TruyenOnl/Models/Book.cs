using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using TruyenOnl.Models;

namespace TruyenOnl.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }

        public string ImagePath { get; set; }
        public IFormFile UploadImage { get; set; }

        public int Rating { get; set; }
        public string Review { get; set; }
        public string Author { get; set; }
        public int ChapterCount { get; set; }

        public List<BookInCategory> BookInCategories { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}