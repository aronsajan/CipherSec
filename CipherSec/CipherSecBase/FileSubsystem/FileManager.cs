using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecBase.FileSubsystem
{
    public class FileManager
    {
        public static void WriteData(byte[] Data, String Filename)
        {
            try
            {
                FileStream WriteStream = new FileStream(Filename, FileMode.Create, FileAccess.Write);
                WriteStream.Write(Data, 0, Data.Length);
                WriteStream.Close();
            }
            catch(Exception Ex)
            {
                throw new ApplicationException("Exception occured while writing data to file - " + Filename + ". Details: " + Ex.Message);
            }
        }

        public static byte[] ReadData(String Filename)
        {
            FileStream ReadStream = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            FileInfo FInfo = new FileInfo(Filename);
            int FileSize = (int)FInfo.Length;
            byte[] binData = new byte[FileSize];
            return binData;
        }
    }
}
