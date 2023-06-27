using Accounting.DataLayer;
using Accounting.DataLayer.Models;
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
    public partial class frmEditProfile : Form
    {
        public frmEditProfile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    errorProvider.Clear();
                    if (db.loginRepository.GetAll(c => c.Username == txtUsername.Text).Any())
                    {
                        errorProvider.Clear();
                        Login user = db.loginRepository.GetAll(c => c.Username == txtUsername.Text).First();
                        if (user.Password == txtCurrent.Text)
                        {
                            errorProvider.Clear();

                            if (txtNew.Text == txtConfirm.Text)
                            {
                                user.Password = txtConfirm.Text;
                                user.Username = txtUsername.Text;
                                db.loginRepository.Update(user);
                                db.Save();
                                Application.Restart();
                            }
                            else
                            {
                                errorProvider.SetError(txtConfirm, "New Password and confirm " +
                                    "password does not mach");
                            }
                        }
                        else
                        {
                            errorProvider.SetError(txtCurrent, "Wrong Password !!!");

                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtUsername, "Wrong Username !!!");
                    }

                }
            }
        }
    }
}
