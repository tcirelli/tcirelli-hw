﻿using System.Text.Json;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class HolidaysApiService : IHolidaysApiService
    {
        private readonly HttpClient client;

        public HolidaysApiService(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("PublicHolidaysApi");
        }
        public async Task<List<HolidayModel>> GetHolidays(string countryCode, int year)
        {
            var url = string.Format("/api/v2/PublicHolidays/{0}/{1}", year, countryCode);
            var result = new List<HolidayModel>();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<List<HolidayModel>>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
            return result;
        }

    }

}
