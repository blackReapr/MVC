using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index(int? countryId)
        {
            List<City> cities = new()
            {
                new() { Id=1, Name="City1", CountryId=1},
                new() { Id=2, Name="City2", CountryId=2},
                new() { Id=3, Name="City3", CountryId=2},
                new() { Id=4, Name="City4", CountryId=3},
                new() { Id=5, Name="City5", CountryId=4},
                new() { Id=6, Name="City6", CountryId=4},
                new() { Id=7, Name="City7", CountryId=4},
                new() { Id=8, Name="City8", CountryId=5},
            };
            if (countryId is null) return View(cities);
            if (!cities.Exists(city => city.CountryId == countryId)) return NotFound();
            return View(cities.FindAll(city => city.CountryId == countryId));
        }
    }
}
