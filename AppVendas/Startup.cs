using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppVendas.Models;
using AppVendas.Data;
using AppVendas.Services;

namespace AppVendas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            /* services.AddDbContext<AppVendasContext>(options =>
                     //options.UseSqlServer(Configuration.GetConnectionString("AppVendasContext")));
                     options.UseMySql(Configuration.GetConnectionString("AppVendasContext"), builder => builder.MigrationsAssembly("AppVendas")));
         */
            services.AddDbContext<AppVendasContext>(options => options.UseMySql(
                Configuration.GetConnectionString("AppVendasContext"),
                new MySqlServerVersion(new Version(8, 0, 21)), // Substitua pela versão correta do seu MySQL
                builder => builder.MigrationsAssembly("AppVendas")));
            services.AddScoped<SeedingService>();
            services.AddScoped<SellerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SeedingService seedingService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                seedingService.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
