using ImageHoster.Domain.Exceptions.BasicPhotoExceptions;
using System.Reflection;
using System.Security.Cryptography;

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
            string description,
            string image)
        {
            Id = Guid.NewGuid();
            Title = EncriptMystring(image);
			SetDescription(description);
            SetImage(image);
            AddedDate = DateTime.UtcNow;
        }

        private void SetTitle(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException();
            }

            Title = title;
        }

        private void SetDescription(string description)
        {
            if(string.IsNullOrWhiteSpace(description)) 
            {
                throw new ArgumentNullException();
            }

            Description = description;
        }

        private void SetImage(string image)
        {
            
            if(string.IsNullOrWhiteSpace(image))
            {
                throw new ArgumentNullException();
            }

            Image = image;
        }

        private string EncriptMystring(string image)
        {
            image = image + DateTime.UtcNow.ToString("yy/MM/dd HH/MM/ss");
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(image);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
