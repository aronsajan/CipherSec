using CipherSecCommon.CommonExceptions;
using CipherSecCommon.StatusCommunicator;
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
   
    public partial class CommandLineUnlockForm : Form
    {
        StatusRelay statusRelayCommunicator;
        public CommandLineUnlockForm()
        {
            InitializeComponent();
            DirectorySelectionDialog.SelectedPath = "";
            statusRelayCommunicator = new StatusRelay(Status);
        }
        public String Filename
        {
            get;
            set;
        }

        private void BtnTargetLocation_Click(object sender, EventArgs e)
        {
            if(DirectorySelectionDialog.ShowDialog()==DialogResult.OK)
            {
                TxtTargetLocation.Text = DirectorySelectionDialog.SelectedPath;
            }
        }

        private void BtnUnlock_Click(object sender, EventArgs e)
        {
            try
            {
                
                FileDecrypter lckDecrypter = new FileDecrypter(Filename, TxtPassword.Text, TxtTargetLocation.Text + "\\", statusRelayCommunicator);
                lckDecrypter.UnlockLCKFile();
                MessageBox.Show("Data unlocked", "Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (DecryptionFailedException DecryptionError)
            {
                MessageBox.Show("Error : Decryption failed due to incorrect password", "Cipher Sec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error : " + Ex.Message, "Cipher Sec Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.Exit();
            }
        }

        public void Status(String Msg, double Percent)
        {

        }
    }
}
