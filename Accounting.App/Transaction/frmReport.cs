
using Accounting.DataLayer;
using Accounting.DataLayer.Models;
using Accounting.Utility;
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
    public partial class frmReport : Form
    {
        public int TypeID;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
           dtFromDate.Value = DateTime.Now.AddDays(-7);
           dtToDate.Value = DateTime.Now;
            using (UnitOfWork db = new UnitOfWork())
            {
                cbCustomer.Items.Add("All customer");
                cbCustomer.Items.AddRange(db.customerRepository.GetAll().Select(x => x.FullName).ToArray());
                cbCustomer.SelectedIndex = 0;
            }
            BindGrid();
            if (TypeID == 1)
            {
                this.Text = "Income Reports";
                dgvReport.ChangeDataGridViewColor(Color.FromArgb(37, 184, 91), Color.FromArgb(129, 247, 172));
                
            }
            else
            {
                this.Text = "Costs Reports";
                dgvReport.ChangeDataGridViewColor(Color.FromArgb(204, 37, 49), Color.Pink);

            }
        }

        private void BindGrid()
        {

            dgvReport.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvReport.DataSource = db.transactionRepository.GetAll(x => x.TypeID == TypeID).Select(x => new { x.ID, x.Customer.FullName, x.Amount, x.Datetime, x.Description, x.TypeID }).OrderBy(x => x.Datetime).ToList();
            }
        }

        private void btnEditReport_Click(object sender, EventArgs e)
        {
            frmTransactionAddOrEdite frm = new frmTransactionAddOrEdite();
            if (dgvReport.CurrentRow != null)
            {
                frm.transaction.ID = (int)dgvReport.CurrentRow.Cells[0].Value;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select One of the Transaction", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveReport_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int transactionId = (int)dgvReport.CurrentRow.Cells[0].Value;
                    if (MessageBox.Show("Are you sure you want to Delete this transaction?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        db.transactionRepository.DeleteById(transactionId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select One of the Transaction", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            frmTransactionAddOrEdite frm = new frmTransactionAddOrEdite();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime fromDate = dtFromDate.Value;
                DateTime toDate = dtToDate.Value;
                if (cbCustomer.Text == "All customer")
                {
                    dgvReport.DataSource = db.transactionRepository.GetAll(x => x.Datetime > fromDate && x.Datetime < toDate && x.TypeID == TypeID).Select(x => new { x.ID, x.Customer.FullName, x.Amount, x.Datetime, x.Description, x.TypeID }).OrderBy(x=> x.Datetime).ToList();
                }
                else
                {
                    dgvReport.DataSource = db.transactionRepository.GetAll(x => x.Datetime > fromDate && x.Datetime < toDate && x.TypeID == TypeID && x.Customer.FullName == cbCustomer.Text).Select(x => new { x.ID, x.Customer.FullName, x.Amount, x.Datetime, x.Description, x.TypeID }).OrderBy(x => x.Datetime).ToList(); 
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Date time");
            dataTable.Columns.Add("Description");


            foreach (DataGridViewRow item in dgvReport.Rows)
            {
                dataTable.Rows.Add
                    (
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );

            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dataTable);
            stiPrint.Show();
        }
    }
}
