using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            progressbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar.Value += 2; //we will increment the value of the progressbar by +2
            progressbar.Text = progressbar.Value.ToString() + "%";
            if (progressbar.Value == 100)
            {
                timer1.Enabled = false;
                Login s = new Login(); // create the object of of login
                s.Show(); // to show the login form
                this.Hide(); // to hide this screen
            }
        }
    }
}
