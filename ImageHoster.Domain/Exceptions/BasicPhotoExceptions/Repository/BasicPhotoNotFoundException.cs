namespace graphicsApp.Exceptions.BasicPhotoExceptions.Repository
{
    public class BasicPhotoNotFoundException : BaseException
    {
        public Guid Id { get; set; }
        public BasicPhotoNotFoundException(Guid id) : base($"Not found BasicPhoto with Id: '{id}'.")
        => Id = id;
        
    }
}
