using ImageHoster.Domain.Repositories;
using ImageHoster.Repositories;

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
