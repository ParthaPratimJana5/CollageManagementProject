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
    public partial class MarkAttendanceForm : Form
    {
        public MarkAttendanceForm()
        {
            InitializeComponent();
        }

        private void MarkAttendanceForm_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn attendanceCol = new DataGridViewComboBoxColumn();
            attendanceCol.Name = "Attendance";
            attendanceCol.HeaderText = "Attendance";

            attendanceCol.Items.Add("Present");
            attendanceCol.Items.Add("Absent");

            dgvAttendance.Columns.Add(attendanceCol);
        }
        
    }
}
