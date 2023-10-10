using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BL;
using DAL.Utils;
using DATA_EF;
using DATA_Models.DTO;
using DATA_Models.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            string tmpdate = rptDate.Value.ToShortDateString();
            if (string.IsNullOrEmpty(tmpdate))
            {
                tmpdate = clsFunction.GetDate().ToShortDateString();
            }

            var data = InvService.GetTop5Products(tmpdate);

            productchart.DataSource = data;
            productchart.Series["Product"].XValueMember = "PRODUCT_NAME";
            productchart.Series["Product"].YValueMembers = "AMOUNT";
            productchart.DataBind();

            var dataIncome = InvService.GetIncome(tmpdate);

            incomechart.DataSource = dataIncome;
            incomechart.Series["income"].XValueMember = "C_DATE";
            incomechart.Series["income"].YValueMembers = "AMOUNT";


            incomechart.Series["income"].XValueType = ChartValueType.DateTime;
            //incomechart.ChartAreas.Add(new ChartArea()); // In some cases the winforms designer adds this already
            //incomechart.ChartAreas["area1"].AxisX.LabelStyle.Format = "yyyy -MM-dd";
            //incomechart.ChartAreas["area1"].AxisX.Interval = 1;
            //incomechart.ChartAreas["area1"].AxisX.IntervalType = DateTimeIntervalType.Months;
            //incomechart.ChartAreas["area1"].AxisX.IntervalOffset = 1;


            incomechart.DataBind();

            if (dataIncome.Count() > 0)
            {
                lblIncome.Text = dataIncome.Select(s => s.STR_TOTAL_INCOME).First();
                lblProfit.Text = dataIncome.Select(s => s.STR_TOTAL_PROFIT).First();
            }

        }

        public void LoadDataLast30()
        {
            InvService invService = new InvService();
            var data = InvService.GetTop5ProductsLast30();

            productchart.DataSource = data;
            productchart.Series["Product"].XValueMember = "PRODUCT_NAME";
            productchart.Series["Product"].YValueMembers = "AMOUNT";
            productchart.DataBind();

            var dataIncome = InvService.GetIncomeLast30();

            incomechart.DataSource = dataIncome;
            incomechart.Series["income"].XValueMember = "C_DATE";
            incomechart.Series["income"].YValueMembers = "AMOUNT";


            incomechart.Series["income"].XValueType = ChartValueType.DateTime;
            //incomechart.ChartAreas.Add(new ChartArea()); // In some cases the winforms designer adds this already
            //incomechart.ChartAreas["area1"].AxisX.LabelStyle.Format = "yyyy -MM-dd";
            //incomechart.ChartAreas["area1"].AxisX.Interval = 1;
            //incomechart.ChartAreas["area1"].AxisX.IntervalType = DateTimeIntervalType.Months;
            //incomechart.ChartAreas["area1"].AxisX.IntervalOffset = 1;


            incomechart.DataBind();

            lblIncome.Text = clsFunction.setFormatCurrency(dataIncome.Select(s => s.AMOUNT).Sum());
            lblProfit.Text = clsFunction.setFormatCurrency(dataIncome.Select(s => s.PROFIT).Sum());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             LoadData();
        }

        private void btnLast30_Click(object sender, EventArgs e)
        {
            LoadDataLast30();
        }
    }
}
