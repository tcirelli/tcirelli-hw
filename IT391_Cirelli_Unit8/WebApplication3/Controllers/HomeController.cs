
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using WebApplication3.Models;
using WebApplication3.Services;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;



namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHolidaysApiService _holidaysApiService;

        public HomeController(IHolidaysApiService holidaysApiService)
        {
            _holidaysApiService = holidaysApiService;
        }

        public async Task<IActionResult> Index(string countryCode, int year)
        {
            List<HolidayModel> holidays = new List<HolidayModel>();
            if (!string.IsNullOrEmpty(countryCode) && year > 0)
            {
                holidays = await _holidaysApiService.GetHolidays(countryCode, year);
            }

            return View(holidays);
        }

    }
}