using graphicsApp.Models;
using graphicsApp.Repositories.Interfaces;
using graphicsApp.Services.Interfaces;

namespace graphicsApp.Services
{
    public class BasicPhotoService : IBasicPhotoService
    {
        private readonly IBasicPhotoRepository basicPhotoRepository;
        
        public BasicPhotoService(IBasicPhotoRepository _basicPhotoRepository)
        {
            basicPhotoRepository = _basicPhotoRepository;
        }
        public IEnumerable<BasicPhoto> GetAllPhotos()
        {
            return basicPhotoRepository.GetAll();
        }

        public BasicPhoto GetPhoto(Guid id)
        {
            return basicPhotoRepository.Get(id);
        }

        public void AddPhoto(
            string title,
            string description,
            string image)
        {
            var photo = new BasicPhoto(title, description, image);

            basicPhotoRepository.AddPhoto(photo);
        }

        public void DeletePhoto(Guid id)
        {
            basicPhotoRepository.DeletePhoto(id);
        }
    }
}
