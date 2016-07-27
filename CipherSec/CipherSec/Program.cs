using CipherSecBase.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherSec
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                SetDefaultWorkingDirectory();

                if (args.Length > 0)
                {
                    string LockedFilename = args[0];

                    int ExtensionStartIndex = LockedFilename.LastIndexOf(".");
                    string Extension = LockedFilename.Substring(ExtensionStartIndex + 1);

                    if (Extension.ToLower().CompareTo("lck") == 0)
                    {

                        CommandLineUnlockForm unlockForm = new CommandLineUnlockForm();
                        unlockForm.Filename = LockedFilename;
                        Application.Run(unlockForm);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Filetype Specified", "Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Application.Run(new CipherSecMain());
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Unhandled Exception. Details - "+Ex.Message+". Cipher Sec will now exit", "Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.ExitCode = 1;
                Application.Exit();
            }
            
            
        }

        static void SetDefaultWorkingDirectory()
        {
            string DefaultWorkingDirectoryConfig = Helper.GetConfigurationValue(ConfigKeys.DefaultWorkingDirectoryConfigFile);
            DefaultWorkingDirectoryConfig = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + DefaultWorkingDirectoryConfig;
            FileInfo FInfo = new FileInfo(DefaultWorkingDirectoryConfig);
            int FileLength = (int)FInfo.Length;
            byte[] FileContentRAW = new byte[FileLength];
            using (FileStream reader = new FileStream(DefaultWorkingDirectoryConfig, FileMode.Open, FileAccess.Read))
            {
                reader.Read(FileContentRAW, 0, FileLength);
            }

            string DefaultWorkingDirectory = ASCIIEncoding.ASCII.GetString(FileContentRAW);
            Environment.CurrentDirectory = DefaultWorkingDirectory;

        }
    }

    
}
