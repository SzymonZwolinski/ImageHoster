using ImageHoster.Domain.Exceptions.BasicPhotoExceptions.Repository;
using ImageHoster.Domain.Models;
using ImageHoster.Domain.Repositories;

namespace ImageHoster.Repositories
{
    public class BasicPhotoRepository : IBasicPhotoRepository
    {
        private readonly List<BasicPhoto> photosMockedDb = new List<BasicPhoto>();
        //TODO: change Mocked data to EF
        public BasicPhotoRepository()
        {
            for(int i = 0; i < 10; i++)
            {
                photosMockedDb.Add(new BasicPhoto(
                    "MockedTitle nr: " + i, 
                    "MockedDescription nr: " + i,
                    "MockedImage nr: " + i));
            }
        }

        public void AddPhoto(BasicPhoto photo)
             => photosMockedDb.Add(photo);

        public void DeletePhoto(Guid id)
        {
            var photo = photosMockedDb.FirstOrDefault(x => x.Id == id);

            photosMockedDb.Remove(photo);
        }

        public BasicPhoto Get(Guid id)
            => photosMockedDb.FirstOrDefault(x => x.Id == id) ?? throw new BasicPhotoNotFoundException(id);

        public IEnumerable<BasicPhoto> GetAll()
            => photosMockedDb.AsEnumerable();
    }
}
