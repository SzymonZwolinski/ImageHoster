using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageHoster.Domain.Exceptions.BasicPhotoExceptions.Repository;
using ImageHoster.Domain.Models;

namespace ImageHoster.Tests.Unit.BasicPhoto.FakeRepository
{
	internal class FakeBasicPhotoRepository
	{
			private readonly List<ImageHoster.Domain.Models.BasicPhoto> photosMockedDb = new List<ImageHoster.Domain.Models.BasicPhoto>();
			public FakeBasicPhotoRepository()
			{
				for (int i = 0; i < 10; i++)
				{
					photosMockedDb.Add(new ImageHoster.Domain.Models.BasicPhoto(
						"MockedTitle nr: " + i,
						"MockedDescription nr: " + i,
						"MockedImage nr: " + i));
				}
			}

			public void AddPhoto(ImageHoster.Domain.Models.BasicPhoto photo)
				 => photosMockedDb.Add(photo);

			public void DeletePhoto(Guid id)
			{
				var photo = photosMockedDb.FirstOrDefault(x => x.Id == id);

				photosMockedDb.Remove(photo);
			}

			public ImageHoster.Domain.Models.BasicPhoto Get(Guid id)
				=> photosMockedDb.FirstOrDefault(x => x.Id == id) ?? throw new BasicPhotoNotFoundException(id);

			public IEnumerable<ImageHoster.Domain.Models.BasicPhoto> GetAll()
				=> photosMockedDb.AsEnumerable();
		
	}
}
