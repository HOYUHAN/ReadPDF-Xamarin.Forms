using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFSampleApp.Services
{
    public class PdfService
    {
        private static string localFilePath = string.Empty;
        public static async Task<string> DownloadAsync(string url)
        {
            var fileName = Guid.NewGuid().ToString();
            // Download PDF locally for viewing

            using (var httpClient = new HttpClient())
            {
                var pdfStream = await httpClient.GetStreamAsync(url);

                localFilePath = await SaveFileToLocalAsync(pdfStream, $"{fileName}.pdf").ConfigureAwait(false);
            }

            if (Device.RuntimePlatform == Device.Android)
                return $"file:///android_asset/pdfjs/web/viewer.html?file={localFilePath}";
            else
                return localFilePath;
        }

        public async static Task<string> SaveFileToLocalAsync(Stream stream, string fileName)
        {
            var rootDir = Xamarin.Essentials.FileSystem.AppDataDirectory;

            if (!Directory.Exists(rootDir))
                Directory.CreateDirectory(rootDir);

            var filePath = Path.Combine(rootDir, fileName);

            using (var memoryStream = new MemoryStream())
            {

                await stream.CopyToAsync(memoryStream).ConfigureAwait(false);

                File.WriteAllBytes(filePath, memoryStream.ToArray());

            }
            return filePath;

        }
    }
}
