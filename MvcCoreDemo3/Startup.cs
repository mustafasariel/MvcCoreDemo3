using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCoreDemo3.Models;

namespace MvcCoreDemo3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connection = @"Server = msariel\SQLEXPRESS; Database = mvcDemo3db; Trusted_Connection = true";

            services.AddDbContext<BlogContex>(option => option.UseSqlServer(connection, null));


            services.AddSession();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            env.EnvironmentName = EnvironmentName.Production;
            if (env.IsDevelopment())
            {
                //geliştirme ortamında hata gösterilir
                app.UseDeveloperExceptionPage();


            }
            else
            {
                app.UseExceptionHandler("/error");
            }


            app.UseSession();
            app.UseMvc(ConfigureRoutes);

            app.UseStaticFiles();
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");


            routeBuilder.MapRoute(
              name: "areas",
              template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
        }

    }
}
