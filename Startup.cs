using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Tutorias
{
    public class Startup
    {
        public IHostingEnvironment Environment { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<Tutorias.Services.MenuService>();
            ////AGREGAR EL SERVICIO DE AUTENTICACION VIA COOKIES
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //ACTIVAR LA AUTENTICACION
            //app.UseAuthentication();

            app.UseFileServer();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                  name: "areas",
                  template: "{Maestro:exists}/{controller=Home}/{action=Index}/{id?}");

                  routes.MapRoute(
                  name: "areas2",
                  template: "{Alumno:exists}/{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
