namespace ImageHoster.Domain.Exceptions.BasicPhotoExceptions
{
    public class TitleIsNullOrWhitespaceException : BaseException
    {
        public TitleIsNullOrWhitespaceException() : base($"Title can not be null or whitespace.")
        {
        }
    }
}
