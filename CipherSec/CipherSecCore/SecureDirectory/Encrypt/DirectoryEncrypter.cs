using CipherSecBase.Cryptographic_Subsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.SecureDirectory.Encrypt
{
    public class DirectoryEncrypter
    {
        public String EncryptDirectory(String UnifiedDirectoryFile, String Password)
        {
            String SourceFile = UnifiedDirectoryFile.Substring(0, UnifiedDirectoryFile.Length - 4);
            CryptographicManager EncryptionManager = new EncryptionEngine();
            EncryptionManager.EncryptFile(UnifiedDirectoryFile, String.Format("{0}.lck", SourceFile), Password);
            return SourceFile;

        }
    }
}
