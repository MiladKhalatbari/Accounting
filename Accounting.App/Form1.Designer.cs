
namespace Accounting.App
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSingout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnPayment = new System.Windows.Forms.ToolStripButton();
            this.btnReceived = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDayReceive = new System.Windows.Forms.Label();
            this.lblMonthReceive = new System.Windows.Forms.Label();
            this.lblYearAccBalance = new System.Windows.Forms.Label();
            this.lblYearPayment = new System.Windows.Forms.Label();
            this.lblYearReceive = new System.Windows.Forms.Label();
            this.lblDayAccBalance = new System.Windows.Forms.Label();
            this.lblDayPayment = new System.Windows.Forms.Label();
            this.lblMonthAccBalance = new System.Windows.Forms.Label();
            this.lblMonthPayment = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.btnSingout,
            this.btnExit});
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Settings";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(180, 22);
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSingout
            // 
            this.btnSingout.Name = "btnSingout";
            this.btnSingout.Size = new System.Drawing.Size(180, 22);
            this.btnSingout.Text = "Sing out";
            this.btnSingout.Click += new System.EventHandler(this.btnSingout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnTransaction,
            this.btnPayment,
            this.btnReceived,
            this.btnRefresh,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(524, 82);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.AutoSize = false;
            this.btnCustomers.Image = global::Accounting.App.Properties.Resources.customers_customer_user_male_512__1_;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(100, 79);
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.AutoSize = false;
            this.btnTransaction.Image = global::Accounting.App.Properties.Resources.clipart_payment__1_;
            this.btnTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(100, 79);
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.AutoSize = false;
            this.btnPayment.Image = global::Accounting.App.Properties.Resources.folder_invoices_icon;
            this.btnPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 79);
            this.btnPayment.Text = "Payment Report";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnReceived
            // 
            this.btnReceived.AutoSize = false;
            this.btnReceived.Image = global::Accounting.App.Properties.Resources._12222211;
            this.btnReceived.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReceived.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(96, 79);
            this.btnReceived.Text = "Received Report";
            this.btnReceived.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::Accounting.App.Properties.Resources.reload__1_;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 79);
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 4);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDatetime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(524, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDatetime
            // 
            this.lblDatetime.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDatetime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDatetime.Size = new System.Drawing.Size(119, 21);
            this.lblDatetime.Text = "{DateTime.now}";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDayReceive
            // 
            this.lblDayReceive.BackColor = System.Drawing.Color.GhostWhite;
            this.lblDayReceive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDayReceive.Location = new System.Drawing.Point(161, 168);
            this.lblDayReceive.Name = "lblDayReceive";
            this.lblDayReceive.Size = new System.Drawing.Size(71, 15);
            this.lblDayReceive.TabIndex = 3;
            this.lblDayReceive.Text = "0";
            // 
            // lblMonthReceive
            // 
            this.lblMonthReceive.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMonthReceive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMonthReceive.Location = new System.Drawing.Point(420, 168);
            this.lblMonthReceive.Name = "lblMonthReceive";
            this.lblMonthReceive.Size = new System.Drawing.Size(71, 15);
            this.lblMonthReceive.TabIndex = 4;
            this.lblMonthReceive.Text = "0";
            // 
            // lblYearAccBalance
            // 
            this.lblYearAccBalance.BackColor = System.Drawing.Color.GhostWhite;
            this.lblYearAccBalance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblYearAccBalance.Location = new System.Drawing.Point(161, 471);
            this.lblYearAccBalance.Name = "lblYearAccBalance";
            this.lblYearAccBalance.Size = new System.Drawing.Size(71, 15);
            this.lblYearAccBalance.TabIndex = 5;
            this.lblYearAccBalance.Text = "0";
            // 
            // lblYearPayment
            // 
            this.lblYearPayment.BackColor = System.Drawing.Color.GhostWhite;
            this.lblYearPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblYearPayment.Location = new System.Drawing.Point(161, 418);
            this.lblYearPayment.Name = "lblYearPayment";
            this.lblYearPayment.Size = new System.Drawing.Size(71, 15);
            this.lblYearPayment.TabIndex = 6;
            this.lblYearPayment.Text = "0";
            // 
            // lblYearReceive
            // 
            this.lblYearReceive.BackColor = System.Drawing.Color.GhostWhite;
            this.lblYearReceive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblYearReceive.Location = new System.Drawing.Point(161, 363);
            this.lblYearReceive.Name = "lblYearReceive";
            this.lblYearReceive.Size = new System.Drawing.Size(71, 15);
            this.lblYearReceive.TabIndex = 7;
            this.lblYearReceive.Text = "0";
            // 
            // lblDayAccBalance
            // 
            this.lblDayAccBalance.BackColor = System.Drawing.Color.GhostWhite;
            this.lblDayAccBalance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDayAccBalance.Location = new System.Drawing.Point(161, 269);
            this.lblDayAccBalance.Name = "lblDayAccBalance";
            this.lblDayAccBalance.Size = new System.Drawing.Size(71, 15);
            this.lblDayAccBalance.TabIndex = 8;
            this.lblDayAccBalance.Text = "0";
            // 
            // lblDayPayment
            // 
            this.lblDayPayment.BackColor = System.Drawing.Color.GhostWhite;
            this.lblDayPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDayPayment.Location = new System.Drawing.Point(161, 217);
            this.lblDayPayment.Name = "lblDayPayment";
            this.lblDayPayment.Size = new System.Drawing.Size(71, 15);
            this.lblDayPayment.TabIndex = 9;
            this.lblDayPayment.Text = "0";
            // 
            // lblMonthAccBalance
            // 
            this.lblMonthAccBalance.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMonthAccBalance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMonthAccBalance.Location = new System.Drawing.Point(420, 269);
            this.lblMonthAccBalance.Name = "lblMonthAccBalance";
            this.lblMonthAccBalance.Size = new System.Drawing.Size(71, 15);
            this.lblMonthAccBalance.TabIndex = 10;
            this.lblMonthAccBalance.Text = "0";
            // 
            // lblMonthPayment
            // 
            this.lblMonthPayment.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMonthPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMonthPayment.Location = new System.Drawing.Point(420, 217);
            this.lblMonthPayment.Name = "lblMonthPayment";
            this.lblMonthPayment.Size = new System.Drawing.Size(71, 15);
            this.lblMonthPayment.TabIndex = 11;
            this.lblMonthPayment.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Accounting.App.Properties.Resources._15565ZZZ9;
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.Controls.Add(this.lblMonthPayment);
            this.Controls.Add(this.lblMonthAccBalance);
            this.Controls.Add(this.lblDayPayment);
            this.Controls.Add(this.lblDayAccBalance);
            this.Controls.Add(this.lblYearReceive);
            this.Controls.Add(this.lblYearPayment);
            this.Controls.Add(this.lblYearAccBalance);
            this.Controls.Add(this.lblMonthReceive);
            this.Controls.Add(this.lblDayReceive);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnTransaction;
        private System.Windows.Forms.ToolStripButton btnPayment;
        private System.Windows.Forms.ToolStripButton btnReceived;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDatetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnSingout;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblDayReceive;
        private System.Windows.Forms.Label lblMonthReceive;
        private System.Windows.Forms.Label lblYearAccBalance;
        private System.Windows.Forms.Label lblYearPayment;
        private System.Windows.Forms.Label lblYearReceive;
        private System.Windows.Forms.Label lblDayAccBalance;
        private System.Windows.Forms.Label lblDayPayment;
        private System.Windows.Forms.Label lblMonthAccBalance;
        private System.Windows.Forms.Label lblMonthPayment;
    }
}

