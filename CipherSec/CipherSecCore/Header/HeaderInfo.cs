using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using CipherSecBase.SerializationSubsystem;

namespace CipherSecCore.Header
{
    [Serializable]
    class HeaderInfo
    {
        public String EntityName
        {
            get;
            set;
        }

        public bool IsDirectory
        {
            get;
            set;
        }

        public byte[] HeaderBinary
        {
            get
            {
                BinarySerializer<HeaderInfo> BinSerializer = new BinarySerializer<HeaderInfo>();
                byte[] HeaderStream = BinSerializer.SerializeData(this);
                return HeaderStream;
            }
        }

        public Int32 HeaderLength
        {
            get
            {
                return (Int32)HeaderBinary.Length;
            }
        }
    }
}
