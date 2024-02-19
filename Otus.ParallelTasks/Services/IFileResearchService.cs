namespace Otus.ParallelTasks.Services;

public interface IFileResearchService
{
    Task<int> CalculateSpacesInFilesAsync(string directoryPath);
}