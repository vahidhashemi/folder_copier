using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foldercopier
{
    class FilePath
    {
        public string file;
        public string shard;

        public FilePath(string file, string shard)
        {
            this.file = file;
            this.shard = shard;
        }
    }
}
