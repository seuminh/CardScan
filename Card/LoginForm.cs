using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm("");
            mainForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Close();
                MainForm mainForm = new MainForm("success");
                mainForm.Show();
            }
            else
                MessageBox.Show("Username Or Password is incorrect","Fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
