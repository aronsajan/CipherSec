using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.Header
{
    class HeaderManager
    {
        public HeaderInfo GetHeader(String entityName, bool isDirectory)
        {
            HeaderInfo info = new HeaderInfo();
            info.EntityName = entityName;
            info.IsDirectory = isDirectory;
            return info;

        }

        
    }
}
