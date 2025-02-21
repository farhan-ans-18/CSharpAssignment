using Microsoft.AspNetCore.Mvc;
using RateCalculation.Models;

namespace RateCalculation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculation(RentCalculation rent)
        {
            ViewBag.start = rent.StartDate;
            ViewBag.end = rent.EndDate;
            ViewBag.name = rent.Name;
            ViewBag.totalCost = (@ViewBag.end.Day - @ViewBag.start.Day) * rent.CostPerDay;
            return View(rent);
        }
        

    }
}
