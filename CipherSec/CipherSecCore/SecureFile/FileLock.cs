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

namespace CipherSecCore.SecureFile
{
    public class FileLock
    {
        FileStream writeStream;
        HeaderManager HeaderCreator = new HeaderManager();
        StatusRelay statusRelay;
        public FileLock(String Filepath, String Password, StatusRelay StatusCommunicate)
        {
            AbsoluteFilename = Filepath;
            this.Password = Password;
            writeStream = new FileStream(TempFilename, FileMode.Create, FileAccess.Write);
            statusRelay = StatusCommunicate;
        }

        String AbsoluteFilename
        {
            get;
            set;
        }

        String Filename
        {
            get
            {
                return Path.GetFileName(AbsoluteFilename);
            }
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


        String OperationsDirectory
        {
            get
            {
                return Helper.GetConfigurationValue(ConfigKeys.TempDirectory);
            }
        }

        String Password
        {
            get;
            set;
        }

        String FileParent
        {
            get
            {
                return Path.GetDirectoryName(AbsoluteFilename);
            }
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
                int ExtensionStartIndex = Filename.LastIndexOf(".");
                String NameWithoutExtension = Filename.Substring(0, ExtensionStartIndex);
                return (String.Format(@"{0}\{1}.tmp", OperationsDirectory, NameWithoutExtension));
            }
        }

        public void LockFile()
        {
            if(!File.Exists(AbsoluteFilename))
            {
                throw new ApplicationException(AbsoluteFilename + " does not exists");
            }

            StatusCommunicate("Extracting file meta-data", 10);
            HeaderInfo Header = GetHeader();
            AddHeaderLength(Header);
            AddHeader(Header);
            StatusCommunicate("Unifying file contents", 40);
            AttachFileBinary();
            DataWriter.Close();
            Encrypter EncryptFile = new Encrypter();
            StatusCommunicate("Encrypting file data", 90);
            String EncryptedFile = EncryptFile.EncryptTMP(TempFilename, Password);
            File.Delete(TempFilename);
            String FinalPath = FileParent + "\\" + Path.GetFileName(EncryptedFile);
            File.Move(EncryptedFile, FinalPath);
            StatusCommunicate("Process completed", 100);


            if(DeleteSource)
            {
                File.Delete(AbsoluteFilename);
            }


        }


        private HeaderInfo GetHeader()
        {

            HeaderInfo HeaderData = HeaderCreator.GetHeader(Filename, false);
            return HeaderData;
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

        private void AttachFileBinary()
        {
            using (FileStream FileReader = new FileStream(AbsoluteFilename, FileMode.Open, FileAccess.Read))
            {
                int BufferSize = int.Parse(Helper.GetConfigurationValue(ConfigKeys.ReaderBufferSize));
                byte[] ReadBuffer = new byte[BufferSize];
                int bytesRead = 0;
                while ((bytesRead = FileReader.Read(ReadBuffer, 0, BufferSize)) > 0)
                {
                    DataWriter.Write(ReadBuffer, 0, bytesRead);
                }
            }

        }


    }
}
