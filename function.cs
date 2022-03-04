﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementMini
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-Q684RHH;initial catalog=Pharmacy;uid=sa; password=sa123";
            return con;
        }
        public DataSet getData(String query)
        {
            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
        public void setData(String query, String msg)
        {
            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
