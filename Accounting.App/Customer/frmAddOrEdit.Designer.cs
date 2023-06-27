
namespace Accounting.App
{
    partial class frmAddOrEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEdit));
            this.txtFullName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txtMobile = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txtEmail = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txtAddress = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.pcCustomer = new System.Windows.Forms.PictureBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.requiredFieldValidatorFullName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidatorMobile = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullName.Location = new System.Drawing.Point(302, 51);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(153, 19);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.WaterMark = "Full Name...";
            this.txtFullName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.GhostWhite;
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMobile.Location = new System.Drawing.Point(302, 103);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(153, 19);
            this.txtMobile.TabIndex = 1;
            this.txtMobile.WaterMark = "Mobile...";
            this.txtMobile.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtMobile.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMobile.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail.Location = new System.Drawing.Point(302, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 19);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.WaterMark = "Email...";
            this.txtEmail.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.Location = new System.Drawing.Point(299, 205);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 53);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.WaterMark = "Address...";
            this.txtAddress.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // pcCustomer
            // 
            this.pcCustomer.Image = global::Accounting.App.Properties.Resources.istockphoto_476085198_612x6121;
            this.pcCustomer.Location = new System.Drawing.Point(12, 32);
            this.pcCustomer.Name = "pcCustomer";
            this.pcCustomer.Size = new System.Drawing.Size(204, 204);
            this.pcCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCustomer.TabIndex = 4;
            this.pcCustomer.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Image = global::Accounting.App.Properties.Resources.confirm_button_png_2_png_image_confirm_png_968_251;
            this.btnSelectPhoto.Location = new System.Drawing.Point(42, 239);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(145, 39);
            this.btnSelectPhoto.TabIndex = 5;
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::Accounting.App.Properties.Resources.confirm_button_png_2_png_image_confirm_png_968_2511;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Location = new System.Drawing.Point(372, 274);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 26);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // requiredFieldValidatorFullName
            // 
            this.requiredFieldValidatorFullName.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidatorFullName.ControlToValidate = this.txtFullName;
            this.requiredFieldValidatorFullName.ErrorMessage = "Please Enter Your Name!";
            this.requiredFieldValidatorFullName.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidatorFullName.Icon")));
            // 
            // requiredFieldValidatorMobile
            // 
            this.requiredFieldValidatorMobile.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidatorMobile.ControlToValidate = this.txtMobile;
            this.requiredFieldValidatorMobile.ErrorMessage = "Please Enter Your Mobile !";
            this.requiredFieldValidatorMobile.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidatorMobile.Icon")));
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Accounting.App.Properties.Resources._1254899774_copyd;
            this.ClientSize = new System.Drawing.Size(494, 311);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.pcCustomer);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtFullName);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Add New Person";
            this.Load += new System.EventHandler(this.FrmAddOrEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChreneLib.Controls.TextBoxes.CTextBox txtFullName;
        private ChreneLib.Controls.TextBoxes.CTextBox txtMobile;
        private ChreneLib.Controls.TextBoxes.CTextBox txtEmail;
        private ChreneLib.Controls.TextBoxes.CTextBox txtAddress;
        private System.Windows.Forms.PictureBox pcCustomer;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Button btnConfirm;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidatorFullName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidatorMobile;
    }
}