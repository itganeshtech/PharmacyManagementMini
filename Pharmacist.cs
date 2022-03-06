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
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnDashBord_Click(object sender, EventArgs e)
        {
           
        }

        private void TesterForm_Load(object sender, EventArgs e)
        {
            btnDashBord.PerformClick();
        }
    }
}
