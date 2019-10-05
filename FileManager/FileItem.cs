using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class FileItem : IDirectoryItem
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Extention { get; set; }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
