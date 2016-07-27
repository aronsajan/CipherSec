
using CipherSecCommon.CommonExceptions;
using CipherSecCommon.StatusCommunicator;
using CipherSecCore.SecureDirectory;
using CipherSecCore.SecureFile;
using CipherSecCore.SecureUnlock;
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
        StatusRelay statusRelayCommunicator;
        public CipherSecMain()
        {
            InitializeComponent();
            statusRelayCommunicator = new StatusRelay(ShowStatus);
            FileSelectionDialog.FileName = "";
            DirectorySelectionDialog.SelectedPath = "";
        }

        

        private void CipherSecMain_Load(object sender, EventArgs e)
        {
           
        }

        private void ButtonDirectorySelect_Click(object sender, EventArgs e)
        {
            if(DirectorySelectionDialog.ShowDialog()==DialogResult.OK)
            {
                TextSelectedDirectory.Text = DirectorySelectionDialog.SelectedPath;
            }
        }

        private void BtnFileSelect_Click(object sender, EventArgs e)
        {
            if(FileSelectionDialog.ShowDialog()==DialogResult.OK)
            {
                TxtLockFile.Text = FileSelectionDialog.FileName;
            }
        }

        private void BtnUnlock_Click(object sender, EventArgs e)
        {
            try
            {
                TextLog.Clear();
                FileDecrypter lckDecrypter = new FileDecrypter(TextUnlockFile.Text, TxtUnlockPassword.Text, TxtUnlockDestination.Text+"\\", statusRelayCommunicator);
                lckDecrypter.UnlockLCKFile();
                MessageBox.Show("Data unlocked", "Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (DecryptionFailedException DecryptionError)
            {
                MessageBox.Show("Error : Decryption failed due to incorrect password","Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgressBar.Value = 0;
                LabelProgessPercent.Text = "0%";
                TextLog.Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Cipher Sec Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSelectLockedFile_Click(object sender, EventArgs e)
        {
            if(FileSelectionDialog.ShowDialog()==DialogResult.OK)
            {
                TextUnlockFile.Text = FileSelectionDialog.FileName;
            }
        }

        public void ShowStatus(String StatusText, Double CompletionPercent)
        {
            ProgressBar.Value = (int)CompletionPercent;
            TextLog.AppendText(StatusText + "\n");
            LabelProgessPercent.Text = CompletionPercent + "%";
        }

        private void BtnLockDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                TextLog.Clear();
                DirectoryLock dirLock = new DirectoryLock(TextSelectedDirectory.Text, TxtDirLockPassword.Text, statusRelayCommunicator);
                dirLock.LockDirectory();
                MessageBox.Show("Directory has been locked", "Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Cipher Sec Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnLockFile_Click(object sender, EventArgs e)
        {
            try
            {
                TextLog.Clear();
                FileLock fileLock = new FileLock(TxtLockFile.Text, TxtFileLockPassword.Text, statusRelayCommunicator);
                fileLock.LockFile();
                MessageBox.Show("File has been locked", "Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Cipher Sec Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSelectUnlockDest_Click(object sender, EventArgs e)
        {
            if(DirectorySelectionDialog.ShowDialog()==DialogResult.OK)
            {
                TxtUnlockDestination.Text = DirectorySelectionDialog.SelectedPath;
            }
        }
    }
}
