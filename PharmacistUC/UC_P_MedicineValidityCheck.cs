﻿using System;
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
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLable.Text = "";
        }
        private void getDataGridView(String query,String labelName,Color col)
        {
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            setLable.Text = labelName;
            setLable.ForeColor = col;
        }
        private void txtUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex==0)
            {
                query = "select * from medic where edate>=getdate()";
                getDataGridView(query, "Valid Medicine", Color.Black);
            }
            else if(txtCheck.SelectedIndex==1)
            {
                query = "select * from medic where edate<=getdate()";
                getDataGridView(query, "Expired Medicine", Color.Red);

            }
            else if(txtCheck.SelectedIndex==2)
            {
                query = "select * from medic";
                getDataGridView(query, "", Color.Black);

            }
            
        }

        
    }
}
