using BL;
using DAL.Utils;
using DATA_EF;
using DATA_Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode.Internal;

namespace POS.Forms
{
    public partial class frmProductManagement : Form
    {
        InventoryDTO pModel = null;
        public frmProductManagement()
        {
            InitializeComponent();
            InitPage();
        }

        void InitPage()
        {
           
            LoadTexboxComplete();
            GetUnit();
        }

        private void GetUnit()
        {
            var parm = ParameterService.GetParameter(PARAMETERCODE.UNITSELL);

            cboUnit.DisplayMember = "NAME";
            cboUnit.ValueMember = "MINOR_CODE";
            cboUnit.DataSource = parm;
        }
        void LoadTexboxComplete()
        {
            List<ProductAutoCompleteDTO> data = new List<ProductAutoCompleteDTO>();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            data = ProductService.GetProductAutoComplete();

            coll.AddRange(data.Select(s => s.PRODUCT_NAME).ToArray());

            txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = coll;
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            INV_PRODUCTS obj = new INV_PRODUCTS();
            var productName = ((TextBox)txtProductName).Text;

           // pModel = InvService.GetAllInventory(code).SingleOrDefault();
        }
    }
}
