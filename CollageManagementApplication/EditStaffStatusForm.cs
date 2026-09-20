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
    public partial class EditStaffStatusForm : Form
    {
        public string StaffID {  get; set; }
        public EditStaffStatusForm()
        {
            InitializeComponent();
        }

        private void EditStaffStatusForm_Load(object sender, EventArgs e)
        {
            Stuff staff = new Stuff();
            DataTable dt = staff.GetAllStaffStatus();
            cmbStatus.DataSource = dt;
            cmbStatus.DisplayMember = "StatusName"; // what user sees
            cmbStatus.ValueMember = "StatusId";     // underlying value

            staff.StaffID = Convert.ToInt32(this.StaffID);
            staff.GetFullStaffInfo();
            lblName.Text = staff.StaffName;
            lblDepartment.Text = staff.StDepartmentName;
            cmbStatus.SelectedValue = staff.StatusId;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int staffId = Convert.ToInt32(this.StaffID);
            int selectedStatusId = (int)cmbStatus.SelectedValue;

            // Confirmation popup
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this staff's status?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                Stuff staff = new Stuff();
                bool result = staff.UpdateStaffStatus(staffId, selectedStatusId);

                if (result)
                {
                    MessageBox.Show("Staff status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed to update staff status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
