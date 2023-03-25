using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllersWithViews();
            service.AddSingleton<IHolidaysApiService, HolidaysApiService>();
            service.AddHttpClient("PublicHolidaysApi", char => char.BaseAddress = new Uri("Https://date.nager.at"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else 
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    nameof: "default",
                    PatternMatcher: "{controller=Home}/{action=Index}/{}");
            });
        }
    }
}