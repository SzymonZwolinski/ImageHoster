using ImageHoster.Domain.Exceptions.BasicPhotoExceptions;
using System.Reflection;

namespace ImageHoster.Domain.Models
{
   public class BasicPhoto
    {
        public Guid Id { get; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public DateTime AddedDate { get; }
        //TODO: Add user field

        public BasicPhoto() { }

        public BasicPhoto(
            string title, 
            string description,
            string image)
        {
            Id = Guid.NewGuid();
            SetTitle(title);
            SetDescription(description);
            SetImage(image);
            AddedDate = DateTime.UtcNow;
        }

        private void SetTitle(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new TitleIsNullOrWhitespaceException();
            }

            Title = title;
        }

        private void SetDescription(string description)
        {
            if(string.IsNullOrWhiteSpace(description)) 
            {
                throw new DescriptionIsNullOrWhitespaceException();
            }

            Description = description;
        }

        private void SetImage(string image)
        {
            if(string.IsNullOrWhiteSpace(image))
            {
                throw new ImageIsNullOrWhitespace();
            }

            Image = image;
        }
    }
}
