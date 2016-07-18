using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecBase.Cryptographic_Subsystem
{
    class EncryptionEngine
    {
        public void EncryptFile(String SourceFile, String OutputFile, String Password)
        {
            RijndaelManaged AESCipher = new RijndaelManaged();
            byte[] PasswordRAW = CryptographicHelper.GetPasswordBinary(Password);
            SHA1 SHA1Hash = SHA1.Create();
            byte[] PasswordHash = SHA1Hash.ComputeHash(PasswordRAW);
            AESCipher.Key = PasswordHash;
            using (FileStream Reader = new FileStream(SourceFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream Writer = new FileStream(OutputFile, FileMode.Create, FileAccess.Write))
                {
                    using (CryptoStream CryptoWriter = new CryptoStream(Writer, AESCipher.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        //WORKING HERE
                    }
                }
            }
            


        }
    }
}
