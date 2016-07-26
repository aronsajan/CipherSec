using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecBase.Cryptographic_Subsystem
{
    static class CryptographicHelper
    {

        public static byte[] GetPasswordBinary(String Password)
        {
            return (UnicodeEncoding.UTF8.GetBytes(Password));
        }

        public static byte[] GetPasswordHash(byte[] PasswordBinary)
        {
            MD5 MD5Hash = MD5.Create();
            byte[] PasswordHash = MD5Hash.ComputeHash(PasswordBinary);
            return PasswordHash;
        }
    }
}
