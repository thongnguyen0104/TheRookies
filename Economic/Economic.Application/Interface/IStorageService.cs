using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Economic.Application.Interface
{
    public interface IStorageService
    {
        string GetFileUrl(string fileName);
        Task DeleteFileAsync(string fileName);
        Task SaveFileAsync(Stream stream, string fileName);
    }
}
