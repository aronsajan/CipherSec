using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSec_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConfigFile = ConfigurationManager.AppSettings["DefaultWorkingDirectoryConfigFile"];
            ConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ConfigFile;
            Console.WriteLine("Configuration File : " + ConfigFile);
            using (FileStream writer = new FileStream(ConfigFile, FileMode.Create, FileAccess.Write))
            {
                string DefaultWorkingDirectory = Environment.CurrentDirectory;
                Console.WriteLine("Setting default working directory : " + DefaultWorkingDirectory);
                byte[] configRAW = ASCIIEncoding.ASCII.GetBytes(DefaultWorkingDirectory.ToCharArray());
                writer.Write(configRAW, 0, configRAW.Length);
            }
        }
    }
}
