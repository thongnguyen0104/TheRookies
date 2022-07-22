using Economic.Application.Interface;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Services
{
    public class StorageService : IStorageService
    {
        private readonly string _imageContentFolder;
        private const string IMAGES_FOLDER_NAME = "Images";

        public StorageService(IWebHostEnvironment webHostEnvironment)
        {
            if (string.IsNullOrWhiteSpace(webHostEnvironment.WebRootPath))
            {
                webHostEnvironment.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            }
            _imageContentFolder = Path.Combine(webHostEnvironment.WebRootPath, IMAGES_FOLDER_NAME);
        }

        public string GetFileUrl(string fileName)
        {
            return $"/{IMAGES_FOLDER_NAME}/{fileName}";
        }

        public async Task DeleteFileAsync(string fileName)
        {
            var filePath = Path.Combine(_imageContentFolder, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }

        public async Task SaveFileAsync(Stream stream, string fileName)
        {
            fileName = fileName != null ? fileName : string.Empty;
            if (!Directory.Exists(_imageContentFolder))
            {
                var createdPath = Directory.CreateDirectory(_imageContentFolder);
            }
            var filePath = Path.Combine(_imageContentFolder, fileName);
            using var output = new FileStream(filePath, FileMode.Create);
            await stream.CopyToAsync(output);
        }
    }
}
