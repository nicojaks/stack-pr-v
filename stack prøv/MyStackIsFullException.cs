public class MyStackIsFullException : Exception
{
    public MyStackIsFullException()
    {
    }

    public MyStackIsFullException(string message)
        : base(message)
    {
    }
}