namespace Otus.ParallelTasks.Services;

public interface IFileResearchService
{
    Task<int> CalculateSpacesInFilesAsync(string directoryPath, CancellationToken token = default);
}