using CipherSecBase.CompressionSubsystem;
using CipherSecBase.Utilities;
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
        public DirectoryUnlock(String TMPFile, HeaderInfo TMPHeader, String TargetLocation)
        {
            DirectoryHeader = TMPHeader;
            TMPFilename = TMPFile;
            targetFile = TargetLocation + TMPHeader.EntityName;
            
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
            ExtractPayloadZIP();
            File.Delete(TMPFilename);
            CompressionManager.DecompressDirectory(ZipFilename, TargetFile);
            File.Delete(ZipFilename);
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
