using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class FeeManagement : Form
    {
        public FeeManagement()
        {
            InitializeComponent();
        }

        private void FeeManagement_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        
    }
}
