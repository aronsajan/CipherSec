﻿namespace CipherSec
{
    partial class CipherSecMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CipherSecMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LabelProgessPercent = new System.Windows.Forms.Label();
            this.TextSelectedDirectory = new System.Windows.Forms.TextBox();
            this.ButtonDirectorySelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLockDirectory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLockFile = new System.Windows.Forms.TextBox();
            this.BtnFileSelect = new System.Windows.Forms.Button();
            this.BtnLockFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextUnlockFile = new System.Windows.Forms.TextBox();
            this.BtnSelectLockedFile = new System.Windows.Forms.Button();
            this.BtnUnlock = new System.Windows.Forms.Button();
            this.TxtUnlockDestination = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSelectUnlockDest = new System.Windows.Forms.Button();
            this.TxtUnlockPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFileLockPassword = new System.Windows.Forms.TextBox();
            this.TxtDirLockPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DirectorySelectionDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileSelectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.AppNameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 148);
            this.panel1.TabIndex = 0;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.Location = new System.Drawing.Point(153, 47);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(218, 46);
            this.AppNameLabel.TabIndex = 2;
            this.AppNameLabel.Text = "Cipher Sec";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 1);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtDirLockPassword);
            this.groupBox1.Controls.Add(this.BtnLockDirectory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonDirectorySelect);
            this.groupBox1.Controls.Add(this.TextSelectedDirectory);
            this.groupBox1.Location = new System.Drawing.Point(22, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lock Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtUnlockPassword);
            this.groupBox2.Controls.Add(this.BtnSelectUnlockDest);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtUnlockDestination);
            this.groupBox2.Controls.Add(this.BtnUnlock);
            this.groupBox2.Controls.Add(this.BtnSelectLockedFile);
            this.groupBox2.Controls.Add(this.TextUnlockFile);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1101, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unlock Entity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtFileLockPassword);
            this.groupBox3.Controls.Add(this.BtnLockFile);
            this.groupBox3.Controls.Add(this.BtnFileSelect);
            this.groupBox3.Controls.Add(this.TxtLockFile);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(570, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 176);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lock File";
            // 
            // TextLog
            // 
            this.TextLog.Location = new System.Drawing.Point(22, 585);
            this.TextLog.Multiline = true;
            this.TextLog.Name = "TextLog";
            this.TextLog.ReadOnly = true;
            this.TextLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextLog.Size = new System.Drawing.Size(1101, 254);
            this.TextLog.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(22, 863);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1052, 23);
            this.ProgressBar.TabIndex = 7;
            // 
            // LabelProgessPercent
            // 
            this.LabelProgessPercent.AutoSize = true;
            this.LabelProgessPercent.Location = new System.Drawing.Point(1080, 863);
            this.LabelProgessPercent.Name = "LabelProgessPercent";
            this.LabelProgessPercent.Size = new System.Drawing.Size(32, 20);
            this.LabelProgessPercent.TabIndex = 8;
            this.LabelProgessPercent.Text = "0%";
            // 
            // TextSelectedDirectory
            // 
            this.TextSelectedDirectory.Location = new System.Drawing.Point(6, 62);
            this.TextSelectedDirectory.Name = "TextSelectedDirectory";
            this.TextSelectedDirectory.Size = new System.Drawing.Size(448, 26);
            this.TextSelectedDirectory.TabIndex = 0;
            // 
            // ButtonDirectorySelect
            // 
            this.ButtonDirectorySelect.Location = new System.Drawing.Point(472, 59);
            this.ButtonDirectorySelect.Name = "ButtonDirectorySelect";
            this.ButtonDirectorySelect.Size = new System.Drawing.Size(40, 32);
            this.ButtonDirectorySelect.TabIndex = 1;
            this.ButtonDirectorySelect.Text = "...";
            this.ButtonDirectorySelect.UseVisualStyleBackColor = true;
            this.ButtonDirectorySelect.Click += new System.EventHandler(this.ButtonDirectorySelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Directory";
            // 
            // BtnLockDirectory
            // 
            this.BtnLockDirectory.Location = new System.Drawing.Point(6, 128);
            this.BtnLockDirectory.Name = "BtnLockDirectory";
            this.BtnLockDirectory.Size = new System.Drawing.Size(167, 33);
            this.BtnLockDirectory.TabIndex = 3;
            this.BtnLockDirectory.Text = "Lock Directory";
            this.BtnLockDirectory.UseVisualStyleBackColor = true;
            this.BtnLockDirectory.Click += new System.EventHandler(this.BtnLockDirectory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select File";
            // 
            // TxtLockFile
            // 
            this.TxtLockFile.Location = new System.Drawing.Point(27, 62);
            this.TxtLockFile.Name = "TxtLockFile";
            this.TxtLockFile.Size = new System.Drawing.Size(456, 26);
            this.TxtLockFile.TabIndex = 1;
            // 
            // BtnFileSelect
            // 
            this.BtnFileSelect.Location = new System.Drawing.Point(497, 59);
            this.BtnFileSelect.Name = "BtnFileSelect";
            this.BtnFileSelect.Size = new System.Drawing.Size(39, 32);
            this.BtnFileSelect.TabIndex = 2;
            this.BtnFileSelect.Text = "...";
            this.BtnFileSelect.UseVisualStyleBackColor = true;
            this.BtnFileSelect.Click += new System.EventHandler(this.BtnFileSelect_Click);
            // 
            // BtnLockFile
            // 
            this.BtnLockFile.Location = new System.Drawing.Point(27, 128);
            this.BtnLockFile.Name = "BtnLockFile";
            this.BtnLockFile.Size = new System.Drawing.Size(165, 33);
            this.BtnLockFile.TabIndex = 3;
            this.BtnLockFile.Text = "Lock File";
            this.BtnLockFile.UseVisualStyleBackColor = true;
            this.BtnLockFile.Click += new System.EventHandler(this.BtnLockFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select Locked File";
            // 
            // TextUnlockFile
            // 
            this.TextUnlockFile.Location = new System.Drawing.Point(10, 71);
            this.TextUnlockFile.Name = "TextUnlockFile";
            this.TextUnlockFile.Size = new System.Drawing.Size(474, 26);
            this.TextUnlockFile.TabIndex = 1;
            // 
            // BtnSelectLockedFile
            // 
            this.BtnSelectLockedFile.Location = new System.Drawing.Point(490, 66);
            this.BtnSelectLockedFile.Name = "BtnSelectLockedFile";
            this.BtnSelectLockedFile.Size = new System.Drawing.Size(34, 37);
            this.BtnSelectLockedFile.TabIndex = 2;
            this.BtnSelectLockedFile.Text = "...";
            this.BtnSelectLockedFile.UseVisualStyleBackColor = true;
            this.BtnSelectLockedFile.Click += new System.EventHandler(this.BtnSelectLockedFile_Click);
            // 
            // BtnUnlock
            // 
            this.BtnUnlock.Location = new System.Drawing.Point(916, 126);
            this.BtnUnlock.Name = "BtnUnlock";
            this.BtnUnlock.Size = new System.Drawing.Size(149, 35);
            this.BtnUnlock.TabIndex = 3;
            this.BtnUnlock.Text = "Unlock";
            this.BtnUnlock.UseVisualStyleBackColor = true;
            this.BtnUnlock.Click += new System.EventHandler(this.BtnUnlock_Click);
            // 
            // TxtUnlockDestination
            // 
            this.TxtUnlockDestination.Location = new System.Drawing.Point(550, 71);
            this.TxtUnlockDestination.Name = "TxtUnlockDestination";
            this.TxtUnlockDestination.Size = new System.Drawing.Size(430, 26);
            this.TxtUnlockDestination.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select Target Location";
            // 
            // BtnSelectUnlockDest
            // 
            this.BtnSelectUnlockDest.Location = new System.Drawing.Point(997, 66);
            this.BtnSelectUnlockDest.Name = "BtnSelectUnlockDest";
            this.BtnSelectUnlockDest.Size = new System.Drawing.Size(38, 36);
            this.BtnSelectUnlockDest.TabIndex = 6;
            this.BtnSelectUnlockDest.Text = "...";
            this.BtnSelectUnlockDest.UseVisualStyleBackColor = true;
            this.BtnSelectUnlockDest.Click += new System.EventHandler(this.BtnSelectUnlockDest_Click);
            // 
            // TxtUnlockPassword
            // 
            this.TxtUnlockPassword.Location = new System.Drawing.Point(94, 116);
            this.TxtUnlockPassword.Name = "TxtUnlockPassword";
            this.TxtUnlockPassword.Size = new System.Drawing.Size(513, 26);
            this.TxtUnlockPassword.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // TxtFileLockPassword
            // 
            this.TxtFileLockPassword.Location = new System.Drawing.Point(119, 96);
            this.TxtFileLockPassword.Name = "TxtFileLockPassword";
            this.TxtFileLockPassword.Size = new System.Drawing.Size(364, 26);
            this.TxtFileLockPassword.TabIndex = 4;
            // 
            // TxtDirLockPassword
            // 
            this.TxtDirLockPassword.Location = new System.Drawing.Point(94, 94);
            this.TxtDirLockPassword.Name = "TxtDirLockPassword";
            this.TxtDirLockPassword.Size = new System.Drawing.Size(360, 26);
            this.TxtDirLockPassword.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // FileSelectionDialog
            // 
            this.FileSelectionDialog.FileName = "openFileDialog1";
            // 
            // CipherSecMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 898);
            this.Controls.Add(this.LabelProgessPercent);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CipherSecMain";
            this.Text = "CipherSecMain";
            this.Load += new System.EventHandler(this.CipherSecMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnLockDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDirectorySelect;
        private System.Windows.Forms.TextBox TextSelectedDirectory;
        private System.Windows.Forms.TextBox TextLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label LabelProgessPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSelectLockedFile;
        private System.Windows.Forms.TextBox TextUnlockFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLockFile;
        private System.Windows.Forms.Button BtnFileSelect;
        private System.Windows.Forms.TextBox TxtLockFile;
        private System.Windows.Forms.TextBox TxtUnlockDestination;
        private System.Windows.Forms.Button BtnUnlock;
        private System.Windows.Forms.Button BtnSelectUnlockDest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUnlockPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDirLockPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFileLockPassword;
        private System.Windows.Forms.FolderBrowserDialog DirectorySelectionDialog;
        private System.Windows.Forms.OpenFileDialog FileSelectionDialog;
    }
}