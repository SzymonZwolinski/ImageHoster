namespace graphicsApp.Exceptions.BasicPhotoExceptions
{
    public class DescriptionIsNullOrWhitespaceException : BaseException
    {
        public DescriptionIsNullOrWhitespaceException( ) : base($"Description can not be null or whitespace")
        {
        }
    }
}
