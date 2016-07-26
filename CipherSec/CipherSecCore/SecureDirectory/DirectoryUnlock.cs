using CipherSecBase.CompressionSubsystem;
using CipherSecBase.Utilities;
using CipherSecCommon.StatusCommunicator;
using CipherSecCore.Header;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.SecureDirectory
{
    class DirectoryUnlock
    {
        string targetFile;
        StatusRelay statusRelay;
        public DirectoryUnlock(String TMPFile, HeaderInfo TMPHeader, String TargetLocation, StatusRelay StatusCommunicate)
        {
            DirectoryHeader = TMPHeader;
            TMPFilename = TMPFile;
            targetFile = TargetLocation + TMPHeader.EntityName;
            statusRelay = StatusCommunicate;
            
        }

        public HeaderInfo DirectoryHeader
        {
            get;
            set;
        }

        public String TargetFile
        {
            get
            {
                return targetFile;
            }
        }

        public StatusRelay StatusCommunicate
        {
            get
            {
                return statusRelay;
            }
        }

        String TMPFilename
        {
            get;
            set;
        }

        String ZipFilename
        {
            get
            {
                return TMPFilename.Substring(0, TMPFilename.Length - 4)+".zip";
            }
        }


        public void UnlockDirectory()
        {
            StatusCommunicate("Extracting payload directory contents", 50);
            ExtractPayloadZIP();
            StatusCommunicate("Directory information extracted", 60);
            File.Delete(TMPFilename);
            StatusCommunicate("Decompressing directory contents", 90);
            CompressionManager.DecompressDirectory(ZipFilename, TargetFile);
            StatusCommunicate("Directory moved to larget location as "+TargetFile, 95);
            File.Delete(ZipFilename);
            StatusCommunicate("Process completed", 100);
        }

        private void ExtractPayloadZIP()
        {
            using (FileStream ZipStream = new FileStream(ZipFilename, FileMode.Create, FileAccess.Write))
            {
                using (FileStream TMPStream = new FileStream(TMPFilename, FileMode.Open, FileAccess.Read))
                {
                    TMPStream.Position = 4 + DirectoryHeader.HeaderLength;
                    int BUFFER_SIZE = int.Parse(Helper.GetConfigurationValue(ConfigKeys.ReaderBufferSize));
                    byte[] ReadBuffer = new byte[BUFFER_SIZE];
                    int bytesRead = 0;
                    while ((bytesRead = TMPStream.Read(ReadBuffer, 0, BUFFER_SIZE)) > 0)
                    {
                        ZipStream.Write(ReadBuffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
