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
            TBA.TbaApi.TestApi();
            /*    
            string ffmpegFilePath = @"/usr/bin/ffmpeg";
            string ffprobeFilePath = @"/usr/bin/ffprobe";

            var videoPath = @"test/test.mp4";
            var thumbnailPath = @"test/thumbnail.jpg";

            var serviceProvider = new ServiceCollection().AddMediaToolkit(ffmpegFilePath, ffprobeFilePath).BuildServiceProvider();
            var service = serviceProvider.GetService<IMediaToolkitService>();

            var metadataTask = new FfTaskGetMetadata(videoPath);
            var metadataResult = await service.ExecuteAsync(metadataTask);

            Console.WriteLine("Get metadata: \n");
            Console.Write(JsonSerializer.Serialize(metadataResult.Metadata));
            Console.WriteLine("\n");

            Console.WriteLine("Save thumbnail: \n");
            var saveThumbnailTask = new FfTaskSaveThumbnail(videoPath, thumbnailPath, TimeSpan.FromSeconds(2));
            await service.ExecuteAsync(saveThumbnailTask);
            */

        }
    }
}
