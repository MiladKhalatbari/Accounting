using Accounting.DataLayer;
using Accounting.DataLayer.Models;
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
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmAddOrEdit : Form
    {
        public Customer customer = new Customer() { CustomerID = 0 };
        string path;
        string location;
        public frmAddOrEdit()
        {

            InitializeComponent();
        }

        private void FrmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (customer.CustomerID != 0)
            {
                this.Text = "Edit Person";
                using (UnitOfWork db = new UnitOfWork())
                {
                    customer = db.customerRepository.GetById(customer.CustomerID);
                    txtAddress.Text = customer.Address;
                    txtFullName.Text = customer.FullName;
                    txtEmail.Text = customer.Email;
                    txtMobile.Text = customer.Mobile;
                    pcCustomer.ImageLocation = Application.StartupPath + @"\Images\" + customer.CustomerImage;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (pcCustomer.ImageLocation != null)
                    {
                        location = pcCustomer.ImageLocation.ToString();
                    }
                    else
                    {
                        location = (Application.StartupPath + "/Images/Default Image.png");
                    }
                    path = Application.StartupPath + "/Images/";

                    if (customer.CustomerID == 0)
                    {
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "/Images/");
                        }
                        string imageName = Guid.NewGuid().ToString() + Path.GetExtension(location);
                        FillCustomer(imageName);
                        try
                        {

                            db.customerRepository.Insert(customer);
                            MessageBox.Show($"Customer : {customer.FullName} Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show($"Something's wrong, we couldn't Add  : {customer.FullName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                    else
                    {
                        string imageName = customer.CustomerImage;
                        FillCustomer(imageName);
                        try
                        {
                            db.customerRepository.Update(customer);
                            MessageBox.Show($"Customer : {customer.FullName} Successfully Edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show($"Something's wrong, we couldn't Edit  : {customer.FullName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void FillCustomer(string imageName)
        {

            pcCustomer.Image.Save(path + imageName);
            customer.CustomerImage = imageName;
            customer.FullName = txtFullName.Text;
            customer.Email = txtEmail.Text;
            customer.Mobile = txtMobile.Text;
            customer.Address = txtAddress.Text;

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }
    }
}
