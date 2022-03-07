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
    public partial class Form1 : Form
    {
        function fn=new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }              
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUserName.Text == "root" && txtPassword.Text == "root")
                {
                    Adminstrator admin = new Adminstrator(txtUserName.Text);
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username='" + txtUserName.Text + "'and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();

                    if (role == "Administrator")
                    {
                        Adminstrator admin = new Adminstrator(txtUserName.Text);
                        admin.Show();
                        this.Hide();

                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist ps = new Pharmacist();
                        ps.Show();
                        this.Hide();

                        //testerform ts = new testerform();
                        //ts.show();
                        //this.hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //SAMPLE CODE FOR HARD CODED USER NAME AND PASSWORD
            //if(txtUserName.Text=="aa" && txtPassword.Text=="aa")
            //{
            //    Adminstrator am = new Adminstrator();
            //    am.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Password or Username.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
