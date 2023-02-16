using ImageHoster.Infrastructure.IOC;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
>>>>>>> f49ee8f14a4b8010155ef877025895b8b4fb7f20

namespace ImageHoster.Blazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var ioCContainer = new IoCContainer(services);
<<<<<<< HEAD
            // Add Razor Pages
            services.AddRazorPages();

            // Add Blazor Server-Side
            services.AddServerSideBlazor();
=======

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Moje API .NET Core",
                    Description = "Przykładowy opis"
                });
            });
>>>>>>> f49ee8f14a4b8010155ef877025895b8b4fb7f20
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
<<<<<<< HEAD
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
=======

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
>>>>>>> f49ee8f14a4b8010155ef877025895b8b4fb7f20
            });
        }
    }
}