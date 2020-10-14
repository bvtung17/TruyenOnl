using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TruyenOnl.Controllers
{
    public class BookController : Controller
    {
        [Route("Book")]
        [Route("Book/Index")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        [Route("Book/CreateBook")]
        public IActionResult CreateBook()
        {
            return View();
        }

        [Route("Book/EditBook")]
        public IActionResult EditBook()
        {
            return View();
        }

        [Route("Book/ChapterList")]
        public IActionResult ChapterList()
        {
            return View();
        }

        [Route("Book/CreateChapter")]
        public IActionResult CreateChapter()
        {
            return View();
        }

        [Route("Book/Statistic")]
        public IActionResult statistic()
        {
            return View();
        }
    }
}
