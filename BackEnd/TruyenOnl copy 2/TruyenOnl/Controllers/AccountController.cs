using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TruyenOnl.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [Route("Account")]
        [Route("Account/Profile")]
        public IActionResult Profile()
        {
            return View();
        }

        [Route("Account/Guide")]
        public IActionResult Guide()
        {
            return View();
        }

        [Route("Account/Reward")]
        public IActionResult Reward()
        {
            return View();
        }

        [Route("Account/Message")]
        public IActionResult Message()
        {
            return View();
        }

        [Route("Account/Notification")]
        public IActionResult Notification()
        {
            return View();
        }

        [Route("Account/HistoryPayment")]
        public IActionResult HistoryPayment()
        {
            return View();
        }

        [Route("Account/Library")]
        public IActionResult Library()
        {
            return View();
        }
    }
}
