namespace CipherSec
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Retype1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDirLockPassword = new System.Windows.Forms.TextBox();
            this.BtnLockDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDirectorySelect = new System.Windows.Forms.Button();
            this.TextSelectedDirectory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUnlockPassword = new System.Windows.Forms.TextBox();
            this.BtnSelectUnlockDest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUnlockDestination = new System.Windows.Forms.TextBox();
            this.BtnUnlock = new System.Windows.Forms.Button();
            this.BtnSelectLockedFile = new System.Windows.Forms.Button();
            this.TextUnlockFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFileLockPassword = new System.Windows.Forms.TextBox();
            this.BtnLockFile = new System.Windows.Forms.Button();
            this.BtnFileSelect = new System.Windows.Forms.Button();
            this.TxtLockFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LabelProgessPercent = new System.Windows.Forms.Label();
            this.DirectorySelectionDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileSelectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Retype2 = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AppNameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 96);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(562, 28);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Unlock";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(432, 28);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(120, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lock Directory";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(300, 28);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lock File";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.Location = new System.Drawing.Point(102, 31);
            this.AppNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(148, 31);
            this.AppNameLabel.TabIndex = 2;
            this.AppNameLabel.Text = "Cipher Sec";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 1);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Retype1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtDirLockPassword);
            this.groupBox1.Controls.Add(this.BtnLockDirectory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonDirectorySelect);
            this.groupBox1.Controls.Add(this.TextSelectedDirectory);
            this.groupBox1.Location = new System.Drawing.Point(14, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(735, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lock Directory";
            // 
            // textBox_Retype1
            // 
            this.textBox_Retype1.Location = new System.Drawing.Point(114, 93);
            this.textBox_Retype1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Retype1.Name = "textBox_Retype1";
            this.textBox_Retype1.Size = new System.Drawing.Size(160, 20);
            this.textBox_Retype1.TabIndex = 7;
            this.textBox_Retype1.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // TxtDirLockPassword
            // 
            this.TxtDirLockPassword.Location = new System.Drawing.Point(114, 68);
            this.TxtDirLockPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDirLockPassword.Name = "TxtDirLockPassword";
            this.TxtDirLockPassword.Size = new System.Drawing.Size(160, 20);
            this.TxtDirLockPassword.TabIndex = 4;
            this.TxtDirLockPassword.UseSystemPasswordChar = true;
            // 
            // BtnLockDirectory
            // 
            this.BtnLockDirectory.Location = new System.Drawing.Point(452, 88);
            this.BtnLockDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLockDirectory.Name = "BtnLockDirectory";
            this.BtnLockDirectory.Size = new System.Drawing.Size(111, 21);
            this.BtnLockDirectory.TabIndex = 3;
            this.BtnLockDirectory.Text = "Lock Directory";
            this.BtnLockDirectory.UseVisualStyleBackColor = true;
            this.BtnLockDirectory.Click += new System.EventHandler(this.BtnLockDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Directory";
            // 
            // ButtonDirectorySelect
            // 
            this.ButtonDirectorySelect.Location = new System.Drawing.Point(452, 37);
            this.ButtonDirectorySelect.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDirectorySelect.Name = "ButtonDirectorySelect";
            this.ButtonDirectorySelect.Size = new System.Drawing.Size(27, 21);
            this.ButtonDirectorySelect.TabIndex = 1;
            this.ButtonDirectorySelect.Text = "...";
            this.ButtonDirectorySelect.UseVisualStyleBackColor = true;
            this.ButtonDirectorySelect.Click += new System.EventHandler(this.ButtonDirectorySelect_Click);
            // 
            // TextSelectedDirectory
            // 
            this.TextSelectedDirectory.Location = new System.Drawing.Point(114, 37);
            this.TextSelectedDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.TextSelectedDirectory.Name = "TextSelectedDirectory";
            this.TextSelectedDirectory.Size = new System.Drawing.Size(325, 20);
            this.TextSelectedDirectory.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(15, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(734, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unlock Entity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // TxtUnlockPassword
            // 
            this.TxtUnlockPassword.Location = new System.Drawing.Point(550, 46);
            this.TxtUnlockPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnlockPassword.Name = "TxtUnlockPassword";
            this.TxtUnlockPassword.Size = new System.Drawing.Size(160, 20);
            this.TxtUnlockPassword.TabIndex = 7;
            this.TxtUnlockPassword.UseSystemPasswordChar = true;
            // 
            // BtnSelectUnlockDest
            // 
            this.BtnSelectUnlockDest.Location = new System.Drawing.Point(454, 76);
            this.BtnSelectUnlockDest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSelectUnlockDest.Name = "BtnSelectUnlockDest";
            this.BtnSelectUnlockDest.Size = new System.Drawing.Size(24, 24);
            this.BtnSelectUnlockDest.TabIndex = 6;
            this.BtnSelectUnlockDest.Text = "...";
            this.BtnSelectUnlockDest.UseVisualStyleBackColor = true;
            this.BtnSelectUnlockDest.Click += new System.EventHandler(this.BtnSelectUnlockDest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select Target Location";
            // 
            // TxtUnlockDestination
            // 
            this.TxtUnlockDestination.Location = new System.Drawing.Point(128, 78);
            this.TxtUnlockDestination.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnlockDestination.Name = "TxtUnlockDestination";
            this.TxtUnlockDestination.Size = new System.Drawing.Size(320, 20);
            this.TxtUnlockDestination.TabIndex = 4;
            // 
            // BtnUnlock
            // 
            this.BtnUnlock.Location = new System.Drawing.Point(550, 77);
            this.BtnUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUnlock.Name = "BtnUnlock";
            this.BtnUnlock.Size = new System.Drawing.Size(99, 23);
            this.BtnUnlock.TabIndex = 3;
            this.BtnUnlock.Text = "Unlock";
            this.BtnUnlock.UseVisualStyleBackColor = true;
            this.BtnUnlock.Click += new System.EventHandler(this.BtnUnlock_Click);
            // 
            // BtnSelectLockedFile
            // 
            this.BtnSelectLockedFile.Location = new System.Drawing.Point(455, 43);
            this.BtnSelectLockedFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSelectLockedFile.Name = "BtnSelectLockedFile";
            this.BtnSelectLockedFile.Size = new System.Drawing.Size(24, 24);
            this.BtnSelectLockedFile.TabIndex = 2;
            this.BtnSelectLockedFile.Text = "...";
            this.BtnSelectLockedFile.UseVisualStyleBackColor = true;
            this.BtnSelectLockedFile.Click += new System.EventHandler(this.BtnSelectLockedFile_Click);
            // 
            // TextUnlockFile
            // 
            this.TextUnlockFile.Location = new System.Drawing.Point(128, 46);
            this.TextUnlockFile.Margin = new System.Windows.Forms.Padding(2);
            this.TextUnlockFile.Name = "TextUnlockFile";
            this.TextUnlockFile.Size = new System.Drawing.Size(320, 20);
            this.TextUnlockFile.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select Locked File";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Retype2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtFileLockPassword);
            this.groupBox3.Controls.Add(this.BtnLockFile);
            this.groupBox3.Controls.Add(this.BtnFileSelect);
            this.groupBox3.Controls.Add(this.TxtLockFile);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(16, 118);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(734, 128);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lock File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password";
            // 
            // TxtFileLockPassword
            // 
            this.TxtFileLockPassword.Location = new System.Drawing.Point(114, 69);
            this.TxtFileLockPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFileLockPassword.Name = "TxtFileLockPassword";
            this.TxtFileLockPassword.Size = new System.Drawing.Size(160, 20);
            this.TxtFileLockPassword.TabIndex = 4;
            this.TxtFileLockPassword.UseSystemPasswordChar = true;
            // 
            // BtnLockFile
            // 
            this.BtnLockFile.Location = new System.Drawing.Point(452, 93);
            this.BtnLockFile.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLockFile.Name = "BtnLockFile";
            this.BtnLockFile.Size = new System.Drawing.Size(110, 21);
            this.BtnLockFile.TabIndex = 3;
            this.BtnLockFile.Text = "Lock File";
            this.BtnLockFile.UseVisualStyleBackColor = true;
            this.BtnLockFile.Click += new System.EventHandler(this.BtnLockFile_Click);
            // 
            // BtnFileSelect
            // 
            this.BtnFileSelect.Location = new System.Drawing.Point(452, 38);
            this.BtnFileSelect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFileSelect.Name = "BtnFileSelect";
            this.BtnFileSelect.Size = new System.Drawing.Size(26, 21);
            this.BtnFileSelect.TabIndex = 2;
            this.BtnFileSelect.Text = "...";
            this.BtnFileSelect.UseVisualStyleBackColor = true;
            this.BtnFileSelect.Click += new System.EventHandler(this.BtnFileSelect_Click);
            // 
            // TxtLockFile
            // 
            this.TxtLockFile.Location = new System.Drawing.Point(114, 38);
            this.TxtLockFile.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLockFile.Name = "TxtLockFile";
            this.TxtLockFile.Size = new System.Drawing.Size(325, 20);
            this.TxtLockFile.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select File";
            // 
            // TextLog
            // 
            this.TextLog.Location = new System.Drawing.Point(15, 263);
            this.TextLog.Margin = new System.Windows.Forms.Padding(2);
            this.TextLog.Multiline = true;
            this.TextLog.Name = "TextLog";
            this.TextLog.ReadOnly = true;
            this.TextLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextLog.Size = new System.Drawing.Size(735, 166);
            this.TextLog.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(15, 451);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(701, 15);
            this.ProgressBar.TabIndex = 7;
            // 
            // LabelProgessPercent
            // 
            this.LabelProgessPercent.AutoSize = true;
            this.LabelProgessPercent.Location = new System.Drawing.Point(720, 451);
            this.LabelProgessPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProgessPercent.Name = "LabelProgessPercent";
            this.LabelProgessPercent.Size = new System.Drawing.Size(21, 13);
            this.LabelProgessPercent.TabIndex = 8;
            this.LabelProgessPercent.Text = "0%";
            // 
            // FileSelectionDialog
            // 
            this.FileSelectionDialog.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Confirm Password";
            // 
            // textBox_Retype2
            // 
            this.textBox_Retype2.Location = new System.Drawing.Point(114, 94);
            this.textBox_Retype2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Retype2.Name = "textBox_Retype2";
            this.textBox_Retype2.Size = new System.Drawing.Size(160, 20);
            this.textBox_Retype2.TabIndex = 7;
            this.textBox_Retype2.UseSystemPasswordChar = true;
            // 
            // CipherSecMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.LabelProgessPercent);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CipherSecMain";
            this.Text = "Cipher Sec";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Retype1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Retype2;
        private System.Windows.Forms.Label label10;
    }
}