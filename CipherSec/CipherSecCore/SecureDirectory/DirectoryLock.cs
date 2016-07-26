using CipherSecBase.CompressionSubsystem;
using CipherSecBase.FileSubsystem;
using CipherSecBase.Utilities;
using CipherSecCommon.StatusCommunicator;
using CipherSecCore.Encrypt;
using CipherSecCore.Header;
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
        StatusRelay statusRelay;
        public DirectoryLock(String directoryPath, String Password, StatusRelay StatusCommunicate)
        {
            DirectoryPath = directoryPath;
            writeStream = new FileStream(TempFilename, FileMode.Create, FileAccess.Write);
            LockPassword = Password;
            statusRelay = StatusCommunicate;
        }

        String DirectoryPath
        {
            get;
            set;
        }

        StatusRelay StatusCommunicate
        {
            get
            {
                return statusRelay;
            }
        }


        bool DeleteSource
        {
            get
            {
                string SourceDeleteFlagText = Helper.GetConfigurationValue(ConfigKeys.DeleteSource);
                return bool.Parse(SourceDeleteFlagText);
            }
        }

        String DirectoryParent
        {
            get
            {
                return Path.GetDirectoryName(DirectoryPath);
            }
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

            StatusCommunicate("Collecting meta-data", 10);
            HeaderInfo Header = GetHeader();

            StatusCommunicate("Compressing directory "+DirectoryName, 40);
            String CompressedFilename = CreateCompressedDirectory();

            StatusCommunicate("Unifying directory information", 40);
            AddHeaderLength(Header);
            AddHeader(Header);
            AttachDirectoryBinary(CompressedFilename);
            StatusCommunicate("Unifying directory information", 50);
            File.Delete(CompressedFilename);
            DataWriter.Close();
            Encrypter EncryptDir = new Encrypter();
            StatusCommunicate("Encrypting directory data", 60);
            String EncryptedFile = EncryptDir.EncryptTMP(TempFilename, LockPassword);
            StatusCommunicate("Directory encryption completed", 90);
            File.Delete(TempFilename);
            String FinalPath = DirectoryParent + "\\" + Path.GetFileName(EncryptedFile);
            File.Move(EncryptedFile, FinalPath);
            StatusCommunicate("Process completed", 100);

            if(DeleteSource)
            {
                Directory.Delete(DirectoryPath,true);
            }
        }

        private HeaderInfo GetHeader()
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
            byte[] LengthBin = BitConverter.GetBytes(Header.HeaderLength);
            DataWriter.Write(LengthBin, 0, LengthBin.Length);
        }

        private void AddHeader(HeaderInfo Header)
        {
            byte[] HeaderBin = Header.HeaderBinary;
            DataWriter.Write(HeaderBin, 0, Header.HeaderLength);
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
