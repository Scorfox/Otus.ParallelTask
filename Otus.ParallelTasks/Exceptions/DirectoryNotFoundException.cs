namespace Otus.ParallelTasks.Exceptions;

public class DirectoryNotFoundException : Exception
{
    public DirectoryNotFoundException(string message) : base(message) { }

    public DirectoryNotFoundException(string message, Exception exception) : base(message, exception) { }
}