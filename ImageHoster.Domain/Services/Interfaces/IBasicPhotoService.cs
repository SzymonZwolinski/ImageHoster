using graphicsApp.Models;

namespace graphicsApp.Services.Interfaces
{
    public interface IBasicPhotoService
    {
        IEnumerable<BasicPhoto> GetAllPhotos();
        BasicPhoto GetPhoto(Guid id);
        void AddPhoto(string title, string description, string image);
        void DeletePhoto(Guid id);
    }
}
