using ImageHoster.Domain.Services;
using ImageHoster.Domain.Services.Interfaces;

namespace ImageHoster.Infrastructure.IOC
{
    public class ServicesIoC
    {
        public ServicesIoC(IServiceCollection services)
        {
           services.AddScoped<IBasicPhotoService, BasicPhotoService>();
        }
    }
}
