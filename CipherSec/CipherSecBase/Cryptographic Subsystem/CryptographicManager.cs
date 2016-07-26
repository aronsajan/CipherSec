using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecBase.Cryptographic_Subsystem
{
    public class CryptographicManager
    {

        public virtual void EncryptFile(String SourceFile, String OutputFile, String Password)
        {
            throw new NotImplementedException();
        }

        public virtual void DecryptFile(String SourceFile, String OutputFile, String Password)
        {
            throw new NotImplementedException();
        }
       
    }
}
