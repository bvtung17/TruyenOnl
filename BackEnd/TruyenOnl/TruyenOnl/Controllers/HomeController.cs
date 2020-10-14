using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using TruyenOnl.Models;

namespace TruyenOnl.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("Home/Search")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("Home/Category")]
        public IActionResult Category()
        {
            return View();
        }

        [Route("Home/Ranking")]
        public IActionResult Ranking()
        {
            return View();
        }

        [Route("Truyen")]
        public IActionResult Truyen()
        {
            return View();
        }

        [Route("Truyen/Reading")]
        public IActionResult Reading()
        {
            return View();
        }
    }
}
