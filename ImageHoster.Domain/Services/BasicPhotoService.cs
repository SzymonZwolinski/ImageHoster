using ImageHoster.Domain.Models;
using ImageHoster.Domain.Repositories;
using ImageHoster.Domain.Services.Interfaces;

namespace ImageHoster.Domain.Services
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
            string description,
            string image)
        {
            var photo = new BasicPhoto(description, image);

            basicPhotoRepository.AddPhoto(photo);
        }

        public void DeletePhoto(Guid id)
        {
            basicPhotoRepository.DeletePhoto(id);
        }
    }
}
