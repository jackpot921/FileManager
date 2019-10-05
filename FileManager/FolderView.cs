using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    class FolderView
    {
        string currentFolder;
        int selectedIndex;
        public FolderView(string path = @"C:\")
        {

        }

        private IEnumerable<FileSystemInfo> GetDirectory()
            => Directory.GetDirectories(currentFolder).Select(s => new DirectoryInfo(s)).Cast<FileSystemInfo>();

        private IEnumerable<FileSystemInfo> GetFile() => Directory.GetFiles(currentFolder).Select(s => new FileInfo(s)).Cast<FileSystemInfo>();
    }
}
