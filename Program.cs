using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using MediaToolkit;
using MediaToolkit.Services;
using MediaToolkit.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace pirec
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string ffmpegFilePath = @"C:\Program Files\ffmpeg\bin\ffmpeg.exe";
            string ffprobeFilePath = @"C:\Program Files\ffmpeg\bin\ffprobe.exe";

            var videoPath = @"C:\Users\Ty\Videos\Recording.mp4";
            var thumbnailPath = @"C:\Users\Ty\Video\Thumbnail.jpeg";

            var service = MediaToolkitService.CreateInstance(ffmpegFilePath);
            var metadataTask = new FfTaskGetMetadata(videoPath);
            var metadataResult = await service.ExecuteAsync(metadataTask);

            Console.WriteLine("Get metadata: \n");
            Console.Write(JsonSerializer.Serialize(metadataResult.Metadata));
            Console.WriteLine("\n");

            Console.WriteLine("Save thumbnail: \n");
            var saveThumbnailTask = new FfTaskSaveThumbnail(videoPath, thumbnailPath, TimeSpan.FromSeconds(2));
            await service.ExecuteAsync(saveThumbnailTask);

        }
    }
}
