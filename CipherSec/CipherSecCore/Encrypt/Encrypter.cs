using CipherSecBase.Cryptographic_Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.Encrypt
{
    class Encrypter
    {
        public String EncryptTMP(String TMPFilename, String Password)
        {
            String SourceFile = TMPFilename.Substring(0, TMPFilename.Length - 4);
            CryptographicManager EncryptionManager = new EncryptionEngine();
            EncryptionManager.EncryptFile(TMPFilename, String.Format("{0}.lck", SourceFile), Password);
            return (SourceFile + ".lck");

        }

    }
}
