using CipherSecBase.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecBase.Cryptographic_Subsystem
{
    public class EncryptionEngine:CryptographicManager
    {
        public override void EncryptFile(String SourceFile, String OutputFile, String Password)
        {
            RijndaelManaged AESCipher = new RijndaelManaged();
            byte[] PasswordRAW = CryptographicHelper.GetPasswordBinary(Password);

            byte[] Key = CryptographicHelper.GetPasswordHash(PasswordRAW);
            byte[] IV = CryptographicHelper.GetPasswordHash(PasswordRAW);
            AESCipher.KeySize = Key.Length*8;
            AESCipher.BlockSize = Key.Length*8;

            using (FileStream Reader = new FileStream(SourceFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream Writer = new FileStream(OutputFile, FileMode.Create, FileAccess.Write))
                {
                    using (CryptoStream CryptoWriter = new CryptoStream(Writer, AESCipher.CreateEncryptor(Key, IV), CryptoStreamMode.Write))
                    {
                        int BUFFER_SIZE = int.Parse(Helper.GetConfigurationValue(ConfigKeys.ReaderBufferSize));
                        byte[] ReadBuffer = new byte[BUFFER_SIZE];
                        int bytesRead = 0;
                        while ((bytesRead = Reader.Read(ReadBuffer, 0, BUFFER_SIZE))>0)
                        {
                            CryptoWriter.Write(ReadBuffer, 0, bytesRead);
                        }

                    }
                }
            }

        }


    }
}
