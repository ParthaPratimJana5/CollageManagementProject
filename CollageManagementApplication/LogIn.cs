using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using BusinessLogicLayer;
namespace CollageManagementApplication
{
    public partial class Login : Form
    {
        string Username = "Matangini";
        string Password = "Mim@123";
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbUsername.Text == Username && txtbPassword.Text == Password)
                
            {
               MainDashboard mainDashboard = new MainDashboard();
               mainDashboard.Show();
               this.Hide();
            }
            else 
            {
                 MessageBox.Show("Please check your UserName or Password");
               
            }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtbUsername.Text = "Matangini";
            txtbPassword.Text = "Mim@123";

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Test()
        {
           // Staff s = new Staff();
           
        }
    }
}
