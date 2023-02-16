
using ImageHoster.Domain.Models;

namespace ImageHoster.Domain.Repositories
{
    public interface IBasicPhotoRepository
    {
        BasicPhoto Get(Guid id);
        IEnumerable<BasicPhoto> GetAll();
        void AddPhoto(BasicPhoto photo);
        void DeletePhoto(Guid id);
    }
}
