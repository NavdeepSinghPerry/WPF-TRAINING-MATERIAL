using Airbnb.Context;
using Airbnb.Controllers;
using Airbnb.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airbnb
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

     //   public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AirbnbContext>(options =>
            options.UseSqlServer("Server=INHYD-5L35R73\\SQLEXPRESS;Database=Airbnb;Integrated Security=True;"));


            services.AddMvc();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#else
            services.AddRazorPages();
#endif

            
            services.AddScoped<RoomsRepository,RoomsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
#if DEBUG
            app.UseDeveloperExceptionPage();
#endif


            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

               // endpoints.MapControllers();
              endpoints.MapDefaultControllerRoute();
              // //endpoints.MapControllerRoute(
              // //    name: "default",
              // //    pattern: "{controller=Home}/{action=Index}/{id?}");
              //  endpoints.MapControllerRoute(
              //  name: "GetRoomNavdeep",
              //  pattern: "get-room",
              //  defaults: new { controller = "Home", action = "GetRooms" });

              //  endpoints.MapControllerRoute(
              //name: "GetRoomNavdeepRoomy",
              //pattern: "get-rommy",
              //defaults: new { controller = "Home", action = "GetRooms" });
            });
        }
    }
}

