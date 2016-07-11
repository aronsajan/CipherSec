using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecBase.SerializationSubsystem
{
    class BinarySerializer<SerializationType>
    {
        public byte[] SerializeData(SerializationType DataObject)
        {
            BinaryFormatter BinSerializer = new BinaryFormatter();
            MemoryStream SerializeStream = new MemoryStream();
            BinSerializer.Serialize(SerializeStream, DataObject);
            byte[] SerializedData = SerializeStream.ToArray();
            return SerializedData;
        }

        public SerializationType DeserializeData(byte[] DataStream)
        {
            BinaryFormatter BinDeserializer = new BinaryFormatter();
            MemoryStream BinaryStream = new MemoryStream(DataStream);
            SerializationType DeserializedData = (SerializationType)BinDeserializer.Deserialize(BinaryStream);
            return DeserializedData;
        }
    }
}
