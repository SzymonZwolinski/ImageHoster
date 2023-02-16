using ImageHoster.Domain.Models;

namespace ImageHoster.Domain.Services.Interfaces
{
    public interface IBasicPhotoService
    {
        IEnumerable<BasicPhoto> GetAllPhotos();
        BasicPhoto GetPhoto(Guid id);
        void AddPhoto(string title, string description, string image);
        void DeletePhoto(Guid id);
    }
}
