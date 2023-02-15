using graphicsApp.Models;

namespace graphicsApp.Repositories.Interfaces
{
    public interface IBasicPhotoRepository
    {
        BasicPhoto Get(Guid id);
        IEnumerable<BasicPhoto> GetAll();
        void AddPhoto(BasicPhoto photo);
        void DeletePhoto(Guid id);
    }
}
