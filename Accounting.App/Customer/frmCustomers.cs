
using Accounting.DataLayer;
using Accounting.DataLayer.Models;
using Accounting.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            dgvCustomers.ChangeDataGridViewColor(Color.FromArgb(85, 65, 156), Color.FromArgb(182, 174, 212));
            BindGrid();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
            frmAddOrEdit.ShowDialog();
            if (frmAddOrEdit.DialogResult == DialogResult.OK) BindGrid();
        }

        private void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.customerRepository.GetAll();
                db.Save();
            }
            txtSearchCustomer.Text = "";
        }

        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {

            BindGrid();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                int customerId = (int)dgvCustomers.CurrentRow.Cells[0].Value;
                Customer customer = db.customerRepository.GetById(customerId);

                if (dgvCustomers.CurrentRow == null)
                {
                    MessageBox.Show("Please select One of the Customers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show($"Are you sure you want to Delete : {customer.FullName}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string path = Application.StartupPath + "/Images/" + customer.CustomerImage;
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        try
                        {
                            db.customerRepository.DeleteById(customerId);


                            MessageBox.Show($"Customer : {customer.FullName} Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.Save();
                            BindGrid();
                        }
                        catch
                        {
                            MessageBox.Show($"Something's wrong, we couldn't Delete  : {customer.FullName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
                int customerId = (int)dgvCustomers.CurrentRow.Cells[0].Value;
                frmAddOrEdit.customer.CustomerID = customerId;
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
            else
            {
                MessageBox.Show("Please select One of the Customers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                string parameters = txtSearchCustomer.Text.ToLower();
                dgvCustomers.DataSource = db.customerRepository.GetAll(x=> x.FullName.ToLower().Contains(parameters)|| x.Email.ToLower().Contains(parameters)|| x.Mobile.ToLower().Contains(parameters));
            }
        }
    }
}
