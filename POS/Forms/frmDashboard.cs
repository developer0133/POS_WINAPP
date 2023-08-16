using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DAL.Utils;
using DATA_EF;
using DATA_Models.DTO;
using DATA_Models.Models;

namespace POS.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            this.LoadData();
        }

        public void LoadData()
        {
            InvService invService = new InvService();
            var data = InvService.GetTop5Products();


            productchart.DataSource = data;
            productchart.Series["Product"].XValueMember = "PRODUCT_NAME";
            productchart.Series["Product"].YValueMembers = "AMOUNT";
            //productchart.DataBind();
        }
    }
}
