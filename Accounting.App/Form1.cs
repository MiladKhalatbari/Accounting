using Accounting.Business;
using Accounting.DataLayer.Models;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
                lblDatetime.Text = DateTime.Now.ToString("M/d hh:mm:ss");

            }
            else
            {
                Application.Exit();
            }
            BindGrid();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransactionAddOrEdite frm = new frmTransactionAddOrEdite();
            frm.ShowDialog();
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID = 1;
            frm.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID = 2;
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("M/d hh:mm:ss");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSingout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
                BindGrid();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ReportViewModel report = CalculateAccountBalance.calculatePerDay();
                lblDayPayment.Text = report.totalCost.ToString("C2");
                lblDayReceive.Text = report.totalIncome.ToString("C2");
                lblDayAccBalance.Text = report.totalBalance.ToString("C2");

               
                report = CalculateAccountBalance.calculatePerMonth();
                lblMonthReceive.Text = report.totalIncome.ToString("C2");
                lblMonthPayment.Text = report.totalCost.ToString("C2");
                lblMonthAccBalance.Text = report.totalBalance.ToString("C2");

                report = CalculateAccountBalance.calculatePerYear();
                lblYearReceive.Text = report.totalIncome.ToString("C2");
                lblYearPayment.Text = report.totalCost.ToString("C2");
                lblYearAccBalance.Text = report.totalBalance.ToString("C2");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmEditProfile frm = new frmEditProfile();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}