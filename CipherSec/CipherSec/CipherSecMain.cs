
using CipherSecCore.SecureDirectory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherSec
{
    public partial class CipherSecMain : Form
    {
        public CipherSecMain()
        {
            InitializeComponent();
        }

        private void CipherSecMain_Load(object sender, EventArgs e)
        {
            DirectoryLock dirLock= new DirectoryLock(@"C:\Users\Aron Sajan Philip\Cipher Sec workspace\Ionic Zip");
            dirLock.LockDirectory();
        }
    }
}
