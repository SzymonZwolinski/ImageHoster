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
<<<<<<< HEAD
}
=======
}
>>>>>>> f49ee8f14a4b8010155ef877025895b8b4fb7f20
