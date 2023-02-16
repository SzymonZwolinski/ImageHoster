using ImageHoster.Infrastructure.IOC;

namespace ImageHoster.Blazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var ioCContainer = new IoCContainer(services);
            // Add Razor Pages
            services.AddRazorPages();

            // Add Blazor Server-Side
            services.AddServerSideBlazor();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
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
            });
        }
    }
}