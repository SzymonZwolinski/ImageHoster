using graphicsApp.Repositories;
using graphicsApp.Services.Interfaces;
using graphicsApp.Services;
using ImageHoster.Domain.Repositories;

namespace ImageHoster.Infrastructure.IOC
{
    public class RepositoriesIoC
    {
        public RepositoriesIoC(IServiceCollection services)
        {
            services.AddScoped<IBasicPhotoRepository, BasicPhotoRepository>();
        }
    }
}
