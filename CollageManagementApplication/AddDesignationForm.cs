using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagementApplication
{
    public partial class AddDesignationForm : Form
    {
        public AddDesignationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveDesignation();
            

        }

        private void SaveDesignation()
        {
            string designationName = txtDesignation.Text;

            if (string.IsNullOrEmpty(designationName))
            {
                MessageBox.Show("Please enter a designation name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to save this designation?" + "Can't Delete Once Saved",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                Designation designation = new Designation();
                string result = designation.AddDesignation(designationName);

                if (result == "1")
                {
                    MessageBox.Show("Designation added successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDesignation.Clear();
                    
                    this.Close();
                }
                else if (result == "0")
                { 
                    MessageBox.Show("Designation already exists.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesignation.ForeColor = Color.Red;
                }
                else
                    MessageBox.Show("An error occurred while adding designation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDesignation_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDesignation.ForeColor == Color.Red)
            {
                txtDesignation.ForeColor = Color.Black;
            }
        }
    }
}
