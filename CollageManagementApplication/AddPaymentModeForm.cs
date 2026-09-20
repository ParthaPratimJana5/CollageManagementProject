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
    public partial class AddPaymentModeForm : Form
    {
        public AddPaymentModeForm()
        {
            InitializeComponent();
        }

        private void AddPaymentMode()
        {
            string payType = txtPaymentMode.Text.Trim();

            if (string.IsNullOrEmpty(payType))
            {
                MessageBox.Show("Please enter a payment type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation popup before saving
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to save this payment type?" + "\n Can't delete once saved ",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                Payment payment = new Payment();
                string result = payment.AddPaymentType(payType);

                if (result == "1")
                {
                    MessageBox.Show("Payment type added successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (result == "0")
                {
                    MessageBox.Show("Payment type already exists.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaymentMode.ForeColor = Color.Red;
                }
                else
                    MessageBox.Show("An error occurred while adding payment type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddPaymentMode();
        }

        private void txtPaymentMode_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPaymentMode.ForeColor == Color.Red)
            {
                txtPaymentMode.ForeColor = Color.Black;
            }
        }
    }
}
