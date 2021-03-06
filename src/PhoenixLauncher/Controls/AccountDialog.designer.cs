namespace PhoenixLauncher.Controls
{
    partial class AccountDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDialog));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.accountBox = new PhoenixLauncher.Controls.AccountBox();
            this.passwordBox = new PhoenixLauncher.Controls.PasswordBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            // 
            // accountBox
            // 
            resources.ApplyResources(this.accountBox, "accountBox");
            this.accountBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accountBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.accountBox.MaximumSize = new System.Drawing.Size(352, 36);
            this.accountBox.MinimumSize = new System.Drawing.Size(50, 36);
            this.accountBox.Name = "accountBox";
            this.accountBox.Value = "";
            // 
            // passwordBox
            // 
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.passwordBox.MaximumSize = new System.Drawing.Size(352, 36);
            this.passwordBox.MinimumSize = new System.Drawing.Size(50, 36);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Value = "";
            // 
            // AccountDialog
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountDialog";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private PhoenixLauncher.Controls.AccountBox accountBox;
        private PhoenixLauncher.Controls.PasswordBox passwordBox;
    }
}