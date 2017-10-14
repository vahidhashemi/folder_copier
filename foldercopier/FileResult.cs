using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foldercopier
{
    class FileResult
    {
        public string file;
        public string id;

        public FileResult(string file, string id)
        {
            this.file = file;
            this.id = id;
        }
    }
}
