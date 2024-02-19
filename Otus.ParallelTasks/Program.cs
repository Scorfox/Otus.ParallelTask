// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Otus.ParallelTasks.Services;

var stopwatch = new Stopwatch();
stopwatch.Start();

IFileResearchService fileResearchService = new FileResearchService();
var spacesCount = await fileResearchService.CalculateSpacesInFilesAsync("./TextFiles");

stopwatch.Stop();

Console.WriteLine($"Spaces count: {spacesCount}");
Console.WriteLine($"Elapsed total seconds: {stopwatch.Elapsed.TotalSeconds}");
