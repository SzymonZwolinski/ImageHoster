namespace ImageHoster.Infrastructure.IOC
{
    public class IoCContainer
    {
        public IoCContainer(IServiceCollection services)
        {
            var repositoriesIoC = new RepositoriesIoC(services);
            var servicesIoC = new ServicesIoC(services);
        }
    }
}