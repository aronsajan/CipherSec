namespace CipherSec
{
    partial class CommandLineUnlockForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTargetLocation = new System.Windows.Forms.TextBox();
            this.BtnTargetLocation = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.BtnUnlock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DirectorySelectionDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Location";
            // 
            // TxtTargetLocation
            // 
            this.TxtTargetLocation.Location = new System.Drawing.Point(32, 56);
            this.TxtTargetLocation.Name = "TxtTargetLocation";
            this.TxtTargetLocation.Size = new System.Drawing.Size(481, 26);
            this.TxtTargetLocation.TabIndex = 1;
            // 
            // BtnTargetLocation
            // 
            this.BtnTargetLocation.Location = new System.Drawing.Point(519, 51);
            this.BtnTargetLocation.Name = "BtnTargetLocation";
            this.BtnTargetLocation.Size = new System.Drawing.Size(46, 36);
            this.BtnTargetLocation.TabIndex = 2;
            this.BtnTargetLocation.Text = "...";
            this.BtnTargetLocation.UseVisualStyleBackColor = true;
            this.BtnTargetLocation.Click += new System.EventHandler(this.BtnTargetLocation_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(32, 126);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(481, 26);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(33, 100);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(78, 20);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Password";
            // 
            // BtnUnlock
            // 
            this.BtnUnlock.Location = new System.Drawing.Point(484, 186);
            this.BtnUnlock.Name = "BtnUnlock";
            this.BtnUnlock.Size = new System.Drawing.Size(113, 37);
            this.BtnUnlock.TabIndex = 5;
            this.BtnUnlock.Text = "Unlock";
            this.BtnUnlock.UseVisualStyleBackColor = true;
            this.BtnUnlock.Click += new System.EventHandler(this.BtnUnlock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(2, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 1);
            this.panel1.TabIndex = 6;
            // 
            // CommandLineUnlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 234);
            this.Controls.Add(this.BtnUnlock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.BtnTargetLocation);
            this.Controls.Add(this.TxtTargetLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CommandLineUnlockForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cipher Sec - Unlock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTargetLocation;
        private System.Windows.Forms.Button BtnTargetLocation;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button BtnUnlock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog DirectorySelectionDialog;
    }
}