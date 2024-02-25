namespace Otus.ParallelTasks.Services;

public class FileResearchService : IFileResearchService
{
    public async Task<int> CalculateSpacesInFilesAsync(string directoryPath, CancellationToken token = default)
    {
        if (!Directory.Exists(directoryPath))
            throw new DirectoryNotFoundException($"Directory {directoryPath} not found");
        
        var allFilePaths = Directory.GetFiles(directoryPath);
        var tasks = allFilePaths.Select(CalculateSpacesInFileAsync).ToList();
        var results = await Task.WhenAll(tasks);
        return results.Sum();
    }

    private static async Task<int> CalculateSpacesInFileAsync(string filePath)
    {
        var content = await File.ReadAllTextAsync(filePath);
        return content.Count(e => e == ' ');
    }
}