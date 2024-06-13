using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Country> countryList = new()
            {
                new() {Id=1, Name="Country1"},
                new() {Id=2, Name="Country2"},
                new() {Id=3, Name="Country3"},
                new() {Id=4, Name="Country4"},
                new() {Id=5, Name="Country5"},
            };
            return View(countryList);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}
