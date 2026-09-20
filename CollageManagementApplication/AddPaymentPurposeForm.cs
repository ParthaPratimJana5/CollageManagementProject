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
    public partial class AddPaymentPurposeForm : Form
    {
        public AddPaymentPurposeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }


        private void SaveData()
        {

            string paymentPurpose = txtPaymentPerpose.Text;

            if (string.IsNullOrEmpty(paymentPurpose))
            {
                MessageBox.Show("Please enter a payment purpose.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation popup before saving
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to save this payment purpose?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                Payment payment = new Payment();
                string result = payment.AddPaymentPurpose(paymentPurpose);

                if (result == "1")
                {
                    MessageBox.Show("Payment purpose added successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (result == "0")
                {
                    MessageBox.Show("Payment purpose already exists.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaymentPerpose.ForeColor = Color.Red;
                }
                else
                    MessageBox.Show("An error occurred while adding payment purpose.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPaymentPerpose_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPaymentPerpose.ForeColor == Color.Red)
            {
                txtPaymentPerpose.ForeColor = Color.Black;
            }
        }
    }
}
