using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCommon.CommonExceptions
{
   public class DecryptionFailedException:Exception
    {
        public DecryptionFailedException():base("Decryption failed")
        {

        }
    }
}
