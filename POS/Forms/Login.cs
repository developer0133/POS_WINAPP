using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using BL;
using DATA_Models.Models;

namespace POS.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblwarning1.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblwarning1.Text = string.Empty;

            if (txtPwd.Text.Length == 0 || txtUsr.Text.Length == 0)
            {
                lblwarning1.Text = "Input Username or Password !!";
                return;
            }
            else
            {
                LoginModel obj = new LoginModel();
                obj.UserName = txtUsr.Text;
                obj.Password = txtPwd.Text;
                var userData = LoginService.PSSLogin(obj);

                if (userData.USER_ID == 0)
                {
                    lblwarning1.Text = "Invalid Username or Password";
                }
                else
                {
                    var frmMain = new frmMain();
                    this.Hide();
                    frmMain.ShowDialog();
                }

            }

        }
    }
}
