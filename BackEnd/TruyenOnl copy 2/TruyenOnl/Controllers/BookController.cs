using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TruyenOnl.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TruyenOnl.Data.Entities;
using TruyenOnl.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TruyenOnl.Controllers
{
    public class BookController : Controller
    {
        private readonly TruyenOnlDbContext _context;

        public BookController(TruyenOnlDbContext context)
        {
            _context = context;
        }

        //[Route("Book")]
        //[Route("Book/Index")]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [Route("Book")]
        [Route("Book/Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }

        // GET: /<controller>/
        [HttpGet]
        [Route("Book/CreateBook")]
        public IActionResult CreateBook()
        {
            return View();
        }

        [Route("Book/CreateBook")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBook([Bind("Id,Name,Description,ViewCount,DateCreated,Rating,Review,Author,ChapterCount")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book); ;
        }

        [Route("Book/EditBook")]
        [Route("Book/EditBook/{id}")]
        public IActionResult EditBook(int? id)
        {
            return View();
        }

        [Route("Book/ChapterList")]
        [Route("Book/ChapterList/{id}")]
        public async Task<IActionResult> ChapterList(int? id)
        {
            var truyenOnlDbContext = _context.Chapters.Include(c => c.Book);
            return View(await truyenOnlDbContext.ToListAsync());
        }

        [Route("Book/CreateChapter")]
        [HttpGet]
        public IActionResult CreateChapter()
        {
            return View();
        }

        [Route("Book/CreateChapter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateChapter([Bind("Id,BookId,STT,Name,Content,DateCreated")] Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chapter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ChapterList));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Name", chapter.BookId);
            return View(chapter);
        }

        [Route("Book/Statistic")]
        public IActionResult statistic()
        {
            return View();
        }
    }
}
