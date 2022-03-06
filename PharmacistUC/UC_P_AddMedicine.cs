using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementMini.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMediId.Text!="" && txtMediName.Text!="" && txtMediNumber.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="")
            {

            }
            else
            {
                MessageBox.Show("Enter All Data Properly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
