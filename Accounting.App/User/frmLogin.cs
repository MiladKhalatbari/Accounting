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

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void btnlogiin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    try
                    {
                        var user = db.loginRepository.Get(x => x.Username == ctxtUsername.Text && x.Password == ctxtPassword.Text);
                        if (user != null)
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                        MessageBox.Show("Your username or password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Your username or password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
