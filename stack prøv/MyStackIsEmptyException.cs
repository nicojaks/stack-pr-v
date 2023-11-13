public class MyStackIsEmptyException : Exception
{
    public MyStackIsEmptyException()
    {
    }

    public MyStackIsEmptyException(string message)
        : base(message)
    {
    }
}