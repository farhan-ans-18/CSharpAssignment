using Microsoft.AspNetCore.Mvc;
using WelcomeUser.Models;

namespace WelcomeUser.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Display(UserDetail ud)
        {
            ViewBag.name = ud.UserName;
            return View(ud);
        }
    }
}
