using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    interface IDirectoryItem
    {
        string Name { get; set; }
        int Size { get; set; }
        void Show();
    }
}
