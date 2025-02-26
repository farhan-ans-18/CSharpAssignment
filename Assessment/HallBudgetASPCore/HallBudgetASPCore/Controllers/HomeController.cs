using HallBudgetASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HallBudgetASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHallDataAccessModel db;
        public HomeController(IHallDataAccessModel db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(int budget)
        {
            var halls = db.GetHallDetailBy(budget);
            if (halls.Count == 0)
            {
                ViewBag.Message = "No halls found within budget";
            }
            return View(halls);
        }
    }

}
