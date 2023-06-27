
namespace Accounting.App
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.ctxtUsername = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.ctxtPassword = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.btnlogiin = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxtUsername
            // 
            this.ctxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctxtUsername.Location = new System.Drawing.Point(104, 101);
            this.ctxtUsername.Name = "ctxtUsername";
            this.ctxtUsername.Size = new System.Drawing.Size(145, 14);
            this.ctxtUsername.TabIndex = 0;
            this.ctxtUsername.WaterMark = "Username";
            this.ctxtUsername.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.ctxtUsername.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctxtUsername.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // ctxtPassword
            // 
            this.ctxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctxtPassword.Location = new System.Drawing.Point(104, 149);
            this.ctxtPassword.Name = "ctxtPassword";
            this.ctxtPassword.PasswordChar = '*';
            this.ctxtPassword.Size = new System.Drawing.Size(145, 14);
            this.ctxtPassword.TabIndex = 1;
            this.ctxtPassword.WaterMark = "Password...";
            this.ctxtPassword.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.ctxtPassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctxtPassword.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // btnlogiin
            // 
            this.btnlogiin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogiin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogiin.Image = global::Accounting.App.Properties.Resources._17147681_c702_48d8_8df3_afeb7f7d6b56520;
            this.btnlogiin.Location = new System.Drawing.Point(105, 197);
            this.btnlogiin.Name = "btnlogiin";
            this.btnlogiin.Size = new System.Drawing.Size(141, 26);
            this.btnlogiin.TabIndex = 2;
            this.btnlogiin.UseVisualStyleBackColor = true;
            this.btnlogiin.Click += new System.EventHandler(this.btnlogiin_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.ctxtUsername;
            this.requiredFieldValidator3.ErrorMessage = "Please enter your username";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.ctxtPassword;
            this.requiredFieldValidator4.ErrorMessage = "Please enter your password";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // frmLogin
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Accounting.App.Properties.Resources._17147681_c702_48d8_8df3_afeb7f7d6b560;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.btnlogiin);
            this.Controls.Add(this.ctxtPassword);
            this.Controls.Add(this.ctxtUsername);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private ChreneLib.Controls.TextBoxes.CTextBox ctxtUsername;
        private ChreneLib.Controls.TextBoxes.CTextBox ctxtPassword;
        private System.Windows.Forms.Button btnlogiin;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}