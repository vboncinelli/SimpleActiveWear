namespace ActiveWear.Core.Exceptions
{
    public class InvalidLoginException : AppException
    {
        public InvalidLoginException()
        {
        }

        public InvalidLoginException(string? message) : base(message)
        {
        }
    }
}
