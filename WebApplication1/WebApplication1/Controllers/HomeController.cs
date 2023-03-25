using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHolidaysApiService _holidaysApiService;

        public HomeController(IHolidaysApiService holidaysApiService)
        {
            _holidaysApiService = holidaysApiService;
        }

        public async Task<IActionResult>Index(string countryCode, int year)
        {
            List<HolidayModel> holidays = new List<HolidayModel>();
            if (!string.IsNullOrEmpty(countryCode) && year > 0)
            {
                holidays = await _holidaysApiService.GetHolidays(countryCode, year);
            }
        }
           return View(holidays);
        }
    }
}