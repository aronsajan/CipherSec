using CipherSecBase.CompressionSubsystem;
using CipherSecBase.FileSubsystem;
using CipherSecBase.Utilities;
using CipherSecCore.Header;
using CipherSecCore.SecureDirectory.Encrypt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.SecureDirectory
{
    public class DirectoryLock
    {
        HeaderManager HeaderCreator = new HeaderManager();
        FileStream writeStream;
        public DirectoryLock(String directoryPath, String Password)
        {
            DirectoryPath = directoryPath;
            writeStream = new FileStream(TempFilename, FileMode.Create, FileAccess.Write);
            LockPassword = Password;
        }

        String DirectoryPath
        {
            get;
            set;
        }

        String LockPassword
        {
            get;
            set;
        }


        private FileStream DataWriter
        {
            get
            {
                return writeStream;
            }
        }

        private String TempFilename
        {
            get
            {
                return (String.Format(@"{0}\{1}.tmp",OperationsDirectory,DirectoryName));
            }
        }

        String DirectoryName
        {
            get
            {
               return (Path.GetFileName(DirectoryPath));
            }
        }

        String OperationsDirectory
        {
            get
            {
               return Helper.GetConfigurationValue(ConfigKeys.TempDirectory);
            }
        }




        public void LockDirectory()
        {
            if (!Directory.Exists(DirectoryPath))
            {
                throw new ApplicationException("Directory " + DirectoryPath + " does not exists");
            }

            HeaderInfo Header = GetHeader(DirectoryPath);
            String CompressedFilename = CreateCompressedDirectory();

            AddHeaderLength(Header);
            AddHeader(Header);
            AttachDirectoryBinary(CompressedFilename);
            File.Delete(CompressedFilename);
            DataWriter.Close();
            DirectoryEncrypter EncryptDir = new DirectoryEncrypter();
            String EncryptedFile = EncryptDir.EncryptDirectory(TempFilename, LockPassword);
            File.Delete(TempFilename);
            

        }

        private HeaderInfo GetHeader(String DirectoryPath)
        {
           
            HeaderInfo HeaderData = HeaderCreator.GetHeader(DirectoryName, true);
            return HeaderData;
        }

        private String CreateCompressedDirectory()
        {
            String CompressOutputFile = String.Format(@"{0}\{1}.zip", OperationsDirectory, DirectoryName);
            CompressionManager.CompressDirectory(DirectoryPath, CompressOutputFile);
            return CompressOutputFile;
        }

        private void AddHeaderLength(HeaderInfo Header)
        {
            byte[] LengthBin = BitConverter.GetBytes(Header.HeaderBinary.Length);
            DataWriter.Write(LengthBin, 0, LengthBin.Length);
        }

        private void AddHeader(HeaderInfo Header)
        {
            byte[] HeaderBin = Header.HeaderBinary;
            DataWriter.Write(HeaderBin, 0, HeaderBin.Length);
        }

        private void AttachDirectoryBinary(String CompressedDirectoryFile)
        {
            using (FileStream DirReader = new FileStream(CompressedDirectoryFile, FileMode.Open, FileAccess.Read))
            {
                int BufferSize = int.Parse(Helper.GetConfigurationValue(ConfigKeys.ReaderBufferSize));
                byte[] ReadBuffer = new byte[BufferSize];
                int bytesRead = 0;
                while ((bytesRead = DirReader.Read(ReadBuffer, 0, BufferSize)) > 0)
                {
                    DataWriter.Write(ReadBuffer, 0, bytesRead);
                }
            }
            
        }

    
    }
}
