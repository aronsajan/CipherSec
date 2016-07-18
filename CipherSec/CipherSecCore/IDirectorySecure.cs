using CipherSecCore.OperationResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore
{
    public interface IDirectorySecure
    {
        Response LockDirectory(String AbsoluteDirectoryPath);
    }
}
