namespace graphicsApp.Exceptions.BasicPhotoExceptions
{
    public class ImageIsNullOrWhitespace : BaseException
    {
        public ImageIsNullOrWhitespace() : base($"Image can not be null or whitespace")
        {
        }
    }
}
