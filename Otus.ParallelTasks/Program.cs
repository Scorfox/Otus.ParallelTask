// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Otus.ParallelTasks.Services;

var stopwatch = new Stopwatch();
stopwatch.Start();

IFileResearchService fileResearchService = new FileResearchService();
var spacesCount = await fileResearchService.CalculateSpacesInFilesAsync("./TextFiles");

stopwatch.Stop();

Console.WriteLine(spacesCount);
Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
