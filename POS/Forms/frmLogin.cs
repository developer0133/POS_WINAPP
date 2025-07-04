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
using GreatFriends.ThaiBahtText;

namespace POS.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblwarning1.Text = string.Empty;
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lblversion.Text = String.Format("version {0}", version);

            //https://github.com/greatfriends/ThaiBahtText
            //decimal amount = 121.50M;
            //string s = amount.ThaiBahtText();
            //string s23 = (11m).ThaiBahtText();   // สิบเอ็ดบาทถ้วน

            //Guid id = Guid.NewGuid();
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
                    UserModel.USERNAME = userData.USERNAME;
                    UserModel.FIRST_NAME = userData.FIRST_NAME;
                    UserModel.LAST_NAME = userData.LAST_NAME;
                    UserModel.USER_CODE = userData.USER_CODE;
                    UserModel.USER_ID = userData.USER_ID;

                   var frmMain = new frmMain();
                    this.Hide();
                    frmMain.ShowDialog();
                }

            }

        }
    }
}
