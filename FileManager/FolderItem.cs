using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class FolderItem : IDirectoryItem
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
