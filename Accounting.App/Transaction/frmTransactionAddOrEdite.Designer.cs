
namespace Accounting.App
{
    partial class frmTransactionAddOrEdite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionAddOrEdite));
            this.txtSearchName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.dgvNameCustomer = new System.Windows.Forms.DataGridView();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.txtDescription = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txtCustomer = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txtAmount = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Location = new System.Drawing.Point(289, 41);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(130, 15);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.WaterMark = "Search...";
            this.txtSearchName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtSearchName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // dgvNameCustomer
            // 
            this.dgvNameCustomer.AllowUserToAddRows = false;
            this.dgvNameCustomer.AllowUserToDeleteRows = false;
            this.dgvNameCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNameCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNameCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column2,
            this.name});
            this.dgvNameCustomer.Location = new System.Drawing.Point(289, 68);
            this.dgvNameCustomer.Name = "dgvNameCustomer";
            this.dgvNameCustomer.ReadOnly = true;
            this.dgvNameCustomer.Size = new System.Drawing.Size(167, 215);
            this.dgvNameCustomer.TabIndex = 2;
            this.dgvNameCustomer.Click += new System.EventHandler(this.dgvNameCustomer_Click);
            // 
            // column2
            // 
            this.column2.DataPropertyName = "CustomerID";
            this.column2.HeaderText = "Column2";
            this.column2.Name = "column2";
            this.column2.ReadOnly = true;
            this.column2.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "FullName";
            this.name.HeaderText = " Customer Names";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // rbPay
            // 
            this.rbPay.BackgroundImage = global::Accounting.App.Properties.Resources._121315__2_;
            this.rbPay.ImageKey = "(none)";
            this.rbPay.Location = new System.Drawing.Point(158, 78);
            this.rbPay.Name = "rbPay";
            this.rbPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbPay.Size = new System.Drawing.Size(98, 33);
            this.rbPay.TabIndex = 4;
            this.rbPay.UseVisualStyleBackColor = true;
            // 
            // rbGet
            // 
            this.rbGet.BackgroundImage = global::Accounting.App.Properties.Resources._121316__1_;
            this.rbGet.Location = new System.Drawing.Point(59, 78);
            this.rbGet.Name = "rbGet";
            this.rbGet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbGet.Size = new System.Drawing.Size(98, 33);
            this.rbGet.TabIndex = 5;
            this.rbGet.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(79, 196);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 110);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.WaterMark = "Description...";
            this.txtDescription.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDescription.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Location = new System.Drawing.Point(83, 41);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(155, 15);
            this.txtCustomer.TabIndex = 7;
            this.txtCustomer.WaterMark = "Customer...";
            this.txtCustomer.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtCustomer.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCustomer.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.GhostWhite;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(83, 137);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(151, 15);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.WaterMark = "Amount...";
            this.txtAmount.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAmount.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Accounting.App.Properties.Resources.confirm_button_png_2_png_image_confirm_png_968_25111;
            this.btnSave.Location = new System.Drawing.Point(362, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtCustomer;
            this.requiredFieldValidator1.ErrorMessage = "Please Click on name customer!";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtAmount;
            this.rangeValidator1.ErrorMessage = "Please enter JUST number!";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "9999999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtAmount;
            this.requiredFieldValidator2.ErrorMessage = "Please enter amount!";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // frmTransactionAddOrEdite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounting.App.Properties.Resources._121317;
            this.ClientSize = new System.Drawing.Size(490, 330);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.rbGet);
            this.Controls.Add(this.rbPay);
            this.Controls.Add(this.dgvNameCustomer);
            this.Controls.Add(this.txtSearchName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransactionAddOrEdite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ChreneLib.Controls.TextBoxes.CTextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvNameCustomer;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.RadioButton rbGet;
        private ChreneLib.Controls.TextBoxes.CTextBox txtDescription;
        private ChreneLib.Controls.TextBoxes.CTextBox txtCustomer;
        private ChreneLib.Controls.TextBoxes.CTextBox txtAmount;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.Button btnSave;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}