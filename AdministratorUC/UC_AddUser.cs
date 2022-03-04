using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementMini.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {

        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }
               
        public void btnSignup_Click(object sender, EventArgs e)
        {
            String role=txtUserRole.Text;
            String name=txtName.Text;
            String dob=txtDob.Text;
            Int64 mobile=Int64.Parse(txtMobileno.Text);
            String email=txtEmail.Text;
            String username=txtUsername.Text;
            String pass=txtPassword.Text;
            try
            {
                query = "INSERT INTO users(userRole,name, dob, mobile, email, username, pass) values('"+role+"', '"+name+"', '"+dob+"', '"+mobile+"', '"+email+"', '"+username+"', '"+pass+"')";
                fn.setData(query,"Sign up successfull.");
            }
            catch(Exception)
            {
                MessageBox.Show("Username already exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtUserRole.SelectedIndex = -1;
            txtName.Clear();
            txtDob.ResetText();
            txtMobileno.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            pictureBox1.Image = null;          
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUsername.Text + "'";
            if (txtUsername.Text!= "")
            {
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    pictureBox1.ImageLocation = @"C:\Users\USER\source\repos\PharmacyManagementMini\Icons\yes.png";
                }
                else
                {
                    pictureBox1.ImageLocation = @"C:\Users\USER\source\repos\PharmacyManagementMini\Icons\no.png";
                }
            }
        }
    }
}
