namespace CollageManagementApplication
{
    partial class AttendanceManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbDateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddanother = new System.Windows.Forms.Button();
            this.btnSaveAttendance = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpAttandanceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.cmbAttendanceSubject = new System.Windows.Forms.ComboBox();
            this.cmbAttendanceCourse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.txtbDateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 44);
            this.panel1.TabIndex = 0;
            // 
            // txtbDateTime
            // 
            this.txtbDateTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbDateTime.Location = new System.Drawing.Point(790, 11);
            this.txtbDateTime.Multiline = true;
            this.txtbDateTime.Name = "txtbDateTime";
            this.txtbDateTime.ReadOnly = true;
            this.txtbDateTime.Size = new System.Drawing.Size(237, 24);
            this.txtbDateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark Attendance";
            // 
            // btnAddanother
            // 
            this.btnAddanother.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAddanother.Location = new System.Drawing.Point(824, 666);
            this.btnAddanother.Name = "btnAddanother";
            this.btnAddanother.Size = new System.Drawing.Size(203, 33);
            this.btnAddanother.TabIndex = 7;
            this.btnAddanother.Text = "Add Another (Clear Form)";
            this.btnAddanother.UseVisualStyleBackColor = true;
            this.btnAddanother.Click += new System.EventHandler(this.btnAddanother_Click);
            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSaveAttendance.Location = new System.Drawing.Point(562, 666);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.Size = new System.Drawing.Size(203, 33);
            this.btnSaveAttendance.TabIndex = 8;
            this.btnSaveAttendance.Text = "Save Attendance";
            this.btnSaveAttendance.UseVisualStyleBackColor = true;
            this.btnSaveAttendance.Click += new System.EventHandler(this.btnSaveAttendance_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colStudentname,
            this.colPresent});
            this.dgvAttendance.Location = new System.Drawing.Point(24, 262);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.Size = new System.Drawing.Size(1003, 366);
            this.dgvAttendance.TabIndex = 6;
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "StudentID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Width = 320;
            // 
            // colStudentname
            // 
            this.colStudentname.HeaderText = "Student Name";
            this.colStudentname.Name = "colStudentname";
            this.colStudentname.Width = 350;
            // 
            // colPresent
            // 
            this.colPresent.HeaderText = "Present";
            this.colPresent.Name = "colPresent";
            this.colPresent.Width = 300;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.dtpAttandanceDate);
            this.panel2.Controls.Add(this.cmbBatch);
            this.panel2.Controls.Add(this.cmbAttendanceSubject);
            this.panel2.Controls.Add(this.cmbAttendanceCourse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(24, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 181);
            this.panel2.TabIndex = 5;
            // 
            // dtpAttandanceDate
            // 
            this.dtpAttandanceDate.Location = new System.Drawing.Point(787, 39);
            this.dtpAttandanceDate.Name = "dtpAttandanceDate";
            this.dtpAttandanceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAttandanceDate.TabIndex = 4;
            // 
            // cmbBatch
            // 
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(183, 87);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(194, 21);
            this.cmbBatch.TabIndex = 3;
            this.cmbBatch.Text = "Select Batch or Year";
            // 
            // cmbAttendanceSubject
            // 
            this.cmbAttendanceSubject.FormattingEnabled = true;
            this.cmbAttendanceSubject.Location = new System.Drawing.Point(181, 132);
            this.cmbAttendanceSubject.Name = "cmbAttendanceSubject";
            this.cmbAttendanceSubject.Size = new System.Drawing.Size(194, 21);
            this.cmbAttendanceSubject.TabIndex = 3;
            this.cmbAttendanceSubject.Text = "Select Subect";
            this.cmbAttendanceSubject.SelectedIndexChanged += new System.EventHandler(this.cmbAttendanceSubject_SelectedIndexChanged);
            // 
            // cmbAttendanceCourse
            // 
            this.cmbAttendanceCourse.FormattingEnabled = true;
            this.cmbAttendanceCourse.Location = new System.Drawing.Point(183, 41);
            this.cmbAttendanceCourse.Name = "cmbAttendanceCourse";
            this.cmbAttendanceCourse.Size = new System.Drawing.Size(194, 21);
            this.cmbAttendanceCourse.TabIndex = 3;
            this.cmbAttendanceCourse.Text = "Select Course";
            this.cmbAttendanceCourse.SelectedIndexChanged += new System.EventHandler(this.cmbAttendanceCourse_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(19, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Batch or Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(723, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course :";
            // 
            // AttendanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 758);
            this.Controls.Add(this.btnAddanother);
            this.Controls.Add(this.btnSaveAttendance);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendanceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceManagement";
            this.Load += new System.EventHandler(this.AttendanceManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDateTime;
        private System.Windows.Forms.Button btnAddanother;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPresent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpAttandanceDate;
        private System.Windows.Forms.ComboBox cmbAttendanceSubject;
        private System.Windows.Forms.ComboBox cmbAttendanceCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label label5;
    }
}