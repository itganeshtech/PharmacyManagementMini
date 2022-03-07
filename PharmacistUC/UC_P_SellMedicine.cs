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
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }
        //mid,mname, mnumber, mDate, eDate, quantity, perunit
        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query= "select mname from medic where eDate>=getdate() and quantity>'0' ";
            ds = fn.getData(query);
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medic where mname like '" +txtSearch.Text+ "%' ";
            ds = fn.getData(query);
            for(int i=0;i<ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnits.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMediName.Text = name;
            query = "select mid,eDate,perUnit from medic where mname='"+name+"' ";
            ds = fn.getData(query);
            txtMediId.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnits.Text!="")
            {

            }
            else
            {

            }
        }
    }
}
