using CipherSecBase.Cryptographic_Subsystem;
using CipherSecBase.SerializationSubsystem;
using CipherSecBase.Utilities;
using CipherSecCore.Header;
using CipherSecCore.SecureDirectory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecCore.SecureUnlock
{
    public class FileDecrypter
    {
        public FileDecrypter(String EncryptedFilename, String Password, String TargetLocation)
        {
            DecryptPassword = Password;
            EncryptedFile = EncryptedFilename;
            this.TargetLocation = TargetLocation;
        }

        String LCKFilename
        {
            get
            {
                return Path.GetFileName(EncryptedFile);
            }
        }

        String TargetLocation
        {
            get;
            set;
        }

        String DecryptPassword
        {
            get;
            set;
        }

        String EncryptedFile
        {
            get;
            set;
        }

        String TMPFilename
        {
            get
            {
                String FilenameTemp = LCKFilename.Substring(0, LCKFilename.Length - 4);
                String WorkingDirectory = Helper.GetConfigurationValue(ConfigKeys.TempDirectory);
                String TMPName = String.Format(@"{0}\{1}.tmp", WorkingDirectory, FilenameTemp);
                return TMPName;
            }
        }

        public void UnlockLCKFile()
        {
            DecryptFile();
            int HeaderLen = GetHeaderLength();
            HeaderInfo TMPHeader = GetHeader(HeaderLen);
           if(TMPHeader.IsDirectory)
            {
                //Routine goes to directory unlocker
                DirectoryUnlock DirUnlock = new DirectoryUnlock(TMPFilename, TMPHeader, TargetLocation);
                DirUnlock.UnlockDirectory();
            }
           else
            {
                //Routine goes to file unlocker
            }
            
        }

        private void DecryptFile()
        {
            String OutputFilename = TMPFilename;
            CryptographicManager DecryptionManager = new DecryptionEngine();
            DecryptionManager.DecryptFile(EncryptedFile, OutputFilename, DecryptPassword);
 
        }

        private int GetHeaderLength()
        {
            int HeaderLength = 0;
            using (FileStream Reader = new FileStream(TMPFilename, FileMode.Open, FileAccess.Read))
            {
                byte[] HeaderLengthRAW = new byte[4];
                Reader.Read(HeaderLengthRAW, 0, 4);
                HeaderLength = BitConverter.ToInt32(HeaderLengthRAW, 0);
            }
            return HeaderLength;
        }

        private HeaderInfo GetHeader(int HeaderLength)
        {
            HeaderInfo TMPHeader;

            using (FileStream Reader = new FileStream(TMPFilename, FileMode.Open, FileAccess.Read))
            {
                byte[] HeaderRAW = new byte[HeaderLength];
                Reader.Position = 4;
                Reader.Read(HeaderRAW, 0, HeaderLength);
                TMPHeader = new BinarySerializer<HeaderInfo>().DeserializeData(HeaderRAW);
            }

            return TMPHeader;
        }
    }
}
