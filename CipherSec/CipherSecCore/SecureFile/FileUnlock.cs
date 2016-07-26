using CipherSecBase.Utilities;
using CipherSecCommon.StatusCommunicator;
using CipherSecCore.Header;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.SecureFile
{
  class FileUnlock
    {
        string targetFile;
        StatusRelay statusRelay;
        public FileUnlock(String TMPFile, HeaderInfo TMPHeader, String TargetLocation, StatusRelay StatusCommunicate)
        {
            FileHeader = TMPHeader;
            TMPFilename = TMPFile;
            targetFile = TargetLocation + TMPHeader.EntityName;
            statusRelay = StatusCommunicate;

        }

        HeaderInfo FileHeader
        {
            get;
            set;
        }

        public string TargetFile
        {
            get
            {
                return targetFile;
            }
        }

        StatusRelay StatusCommunicate
        {
            get
            {
                return statusRelay;
            }
        }


        string TMPFilename
        {
            get;
            set;
        }

        string ActualFileName
        {
            get
            {
                return FileHeader.EntityName;
            }
        }

        public void UnlockFile()
        {
            StatusCommunicate("Extracting payload file", 60);
            ExtractPayloadFile();
            StatusCommunicate("Payload file moved to target location as "+TargetFile, 90);
            File.Delete(TMPFilename);
            StatusCommunicate("Process completed", 100);
        }


        private void ExtractPayloadFile()
        {
            using (FileStream OutStream = new FileStream(TargetFile, FileMode.Create, FileAccess.Write))
            {
                using (FileStream TMPStream = new FileStream(TMPFilename, FileMode.Open, FileAccess.Read))
                {
                    TMPStream.Position = 4 + FileHeader.HeaderLength;
                    int BUFFER_SIZE = int.Parse(Helper.GetConfigurationValue(ConfigKeys.ReaderBufferSize));
                    byte[] ReadBuffer = new byte[BUFFER_SIZE];
                    int bytesRead = 0;
                    while ((bytesRead = TMPStream.Read(ReadBuffer, 0, BUFFER_SIZE)) > 0)
                    {
                        OutStream.Write(ReadBuffer, 0, bytesRead);
                    }
                }
            }
        }


    }
}
