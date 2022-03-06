using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementMini
{
    public partial class Pharmacist : Form
    {
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashBord_Click(object sender, EventArgs e)
        {
            
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            
        }
    }
}
