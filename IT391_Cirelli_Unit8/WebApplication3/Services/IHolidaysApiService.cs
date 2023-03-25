using WebApplication3.Models;

namespace WebApplication3.Services
{
    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
    }

}
