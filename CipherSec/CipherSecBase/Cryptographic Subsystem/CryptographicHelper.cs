using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
