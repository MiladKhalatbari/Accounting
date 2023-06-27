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
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmTransactionAddOrEdite : Form
    {
        public Transaction transaction = new Transaction() { ID = 0 };

        public frmTransactionAddOrEdite()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvNameCustomer.AutoGenerateColumns = false;
                dgvNameCustomer.ChangeDataGridViewColor(Color.FromArgb(85, 65, 156), Color.FromArgb(182, 174, 212));

                dgvNameCustomer.DataSource = db.customerRepository.GetAll().ToList();
                if (transaction.ID != 0)
                {
                    this.Text = "Edit";
                    transaction = db.transactionRepository.GetById(transaction.ID);
                    txtAmount.Text = transaction.Amount.ToString();
                    txtDescription.Text = transaction.Description.ToString();
                    txtCustomer.Text = transaction.Customer.FullName.ToString();
                    if (transaction.TypeID == 1)
                    {
                        rbGet.Checked = true;
                    }
                    else
                    {
                        rbPay.Checked = true;
                    }
                }
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbGet.Checked)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        transaction.Amount = Convert.ToInt32(txtAmount.Text);
                        transaction.Description = txtDescription.Text;
                        transaction.Datetime = DateTime.Now;
                        transaction.TypeID = (rbPay.Checked) ? 2 : 1;
                        if (transaction.ID != 0) db.transactionRepository.Delete(transaction);
                        transaction.CustomerID = db.customerRepository.Get(x => x.FullName == txtCustomer.Text).CustomerID;

                    //}
                    //using (UnitOfWork db = new UnitOfWork())
                    //{
                        if (transaction.ID == 0)
                        {
                            try
                            {
                                db.transactionRepository.Insert(transaction);
                                MessageBox.Show($"Transaction Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show($"Something's wrong, we couldn't Add the Transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            db.transactionRepository.Update(transaction);
                            try
                            {

                                MessageBox.Show($"transaction Successfully Edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show($"Something's wrong, we couldn't Edit the transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        db.Save();
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider1.SetError(rbPay, "Please select the transaction type");
                }
            }
        }

        private void dgvNameCustomer_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = dgvNameCustomer.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                dgvNameCustomer.DataSource = db.customerRepository.GetAll(x => x.FullName.ToLower().Contains(txtSearchName.Text));
            }

        }
    }
}
