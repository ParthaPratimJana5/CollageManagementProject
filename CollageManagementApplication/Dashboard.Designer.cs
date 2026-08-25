namespace CollageManagementApplication
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbDateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtTotalStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtTotalFaculty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtTotalCourse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnCollectFees = new System.Windows.Forms.Button();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.dgvAttendanceReport = new System.Windows.Forms.DataGridView();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.tblCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCollageManagementSyatemDataSet = new CollageManagementApplication.dbCollageManagementSyatemDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.tblCourseTableAdapter = new CollageManagementApplication.dbCollageManagementSyatemDataSetTableAdapters.tblCourseTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCollageManagementSyatemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtbDateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 61);
            this.panel1.TabIndex = 0;
            // 
            // txtbDateTime
            // 
            this.txtbDateTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbDateTime.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDateTime.Location = new System.Drawing.Point(801, 18);
            this.txtbDateTime.Multiline = true;
            this.txtbDateTime.Name = "txtbDateTime";
            this.txtbDateTime.ReadOnly = true;
            this.txtbDateTime.Size = new System.Drawing.Size(238, 24);
            this.txtbDateTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.txtTotalStudent);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(147, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 131);
            this.panel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::CollageManagementApplication.Properties.Resources.Lendo_Um_Stickman_PNG___Mesa__Li_Photoroom;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel9.Location = new System.Drawing.Point(7, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(38, 50);
            this.panel9.TabIndex = 3;
            // 
            // txtTotalStudent
            // 
            this.txtTotalStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalStudent.Location = new System.Drawing.Point(68, 70);
            this.txtTotalStudent.Multiline = true;
            this.txtTotalStudent.Name = "txtTotalStudent";
            this.txtTotalStudent.ReadOnly = true;
            this.txtTotalStudent.Size = new System.Drawing.Size(100, 56);
            this.txtTotalStudent.TabIndex = 2;
            this.txtTotalStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalStudent.TextChanged += new System.EventHandler(this.txtTotalStudent_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Students ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.txtTotalFaculty);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(409, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 131);
            this.panel3.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::CollageManagementApplication.Properties.Resources.Classroom_free_icons_designed_by;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel10.Location = new System.Drawing.Point(31, 7);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(40, 40);
            this.panel10.TabIndex = 3;
            // 
            // txtTotalFaculty
            // 
            this.txtTotalFaculty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalFaculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFaculty.Location = new System.Drawing.Point(66, 70);
            this.txtTotalFaculty.Multiline = true;
            this.txtTotalFaculty.Name = "txtTotalFaculty";
            this.txtTotalFaculty.ReadOnly = true;
            this.txtTotalFaculty.Size = new System.Drawing.Size(100, 56);
            this.txtTotalFaculty.TabIndex = 2;
            this.txtTotalFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(77, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Faculty";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.txtTotalCourse);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(671, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 131);
            this.panel4.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::CollageManagementApplication.Properties.Resources.Graduation_cap_silhouette_restin;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel11.Location = new System.Drawing.Point(11, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(51, 56);
            this.panel11.TabIndex = 3;
            // 
            // txtTotalCourse
            // 
            this.txtTotalCourse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCourse.Location = new System.Drawing.Point(70, 70);
            this.txtTotalCourse.Multiline = true;
            this.txtTotalCourse.Name = "txtTotalCourse";
            this.txtTotalCourse.ReadOnly = true;
            this.txtTotalCourse.Size = new System.Drawing.Size(100, 56);
            this.txtTotalCourse.TabIndex = 2;
            this.txtTotalCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.Location = new System.Drawing.Point(65, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Course";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.btnAddCourse);
            this.panel8.Controls.Add(this.btnCollectFees);
            this.panel8.Controls.Add(this.btnMarkAttendance);
            this.panel8.Controls.Add(this.btnAddStudent);
            this.panel8.Location = new System.Drawing.Point(16, 640);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1023, 106);
            this.panel8.TabIndex = 1;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddCourse.Image = global::CollageManagementApplication.Properties.Resources.graduation;
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(772, 30);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(190, 44);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add Course ";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnCollectFees
            // 
            this.btnCollectFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCollectFees.Image = global::CollageManagementApplication.Properties.Resources.fee_icon_payment_176750902_Photoroom;
            this.btnCollectFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollectFees.Location = new System.Drawing.Point(542, 30);
            this.btnCollectFees.Name = "btnCollectFees";
            this.btnCollectFees.Size = new System.Drawing.Size(190, 44);
            this.btnCollectFees.TabIndex = 0;
            this.btnCollectFees.Text = "Collect Fees";
            this.btnCollectFees.UseVisualStyleBackColor = true;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMarkAttendance.Image = global::CollageManagementApplication.Properties.Resources.attandance_Photoroom__1_;
            this.btnMarkAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkAttendance.Location = new System.Drawing.Point(309, 30);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(190, 44);
            this.btnMarkAttendance.TabIndex = 0;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Image = global::CollageManagementApplication.Properties.Resources.Add_free_icons_designed_by_Bingg;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(71, 30);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(190, 44);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnGenerateReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReports.Location = new System.Drawing.Point(886, 244);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(138, 27);
            this.btnGenerateReports.TabIndex = 0;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // dgvAttendanceReport
            // 
            this.dgvAttendanceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceReport.Location = new System.Drawing.Point(16, 285);
            this.dgvAttendanceReport.Name = "dgvAttendanceReport";
            this.dgvAttendanceReport.Size = new System.Drawing.Size(658, 333);
            this.dgvAttendanceReport.TabIndex = 2;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "Today",
            "This Month",
            "Date Range"});
            this.cmbFilterType.Location = new System.Drawing.Point(35, 243);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(181, 21);
            this.cmbFilterType.TabIndex = 3;
            this.cmbFilterType.Text = "Select Filter type  for Attandance";
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterType_SelectedIndexChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(289, 244);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(145, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(475, 246);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(145, 20);
            this.dtpEndDate.TabIndex = 4;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(741, 247);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(127, 21);
            this.cmbCourse.TabIndex = 5;
            this.cmbCourse.Text = "Select Couese";
            // 
            // tblCourseBindingSource
            // 
            this.tblCourseBindingSource.DataMember = "tblCourse";
            this.tblCourseBindingSource.DataSource = this.dbCollageManagementSyatemDataSet;
            // 
            // dbCollageManagementSyatemDataSet
            // 
            this.dbCollageManagementSyatemDataSet.DataSetName = "dbCollageManagementSyatemDataSet";
            this.dbCollageManagementSyatemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(253, 246);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(453, 249);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "to";
            // 
            // tblCourseTableAdapter
            // 
            this.tblCourseTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 758);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.dgvAttendanceReport);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCollageManagementSyatemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnCollectFees;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtTotalStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtTotalFaculty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtTotalCourse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAttendanceReport;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private dbCollageManagementSyatemDataSet dbCollageManagementSyatemDataSet;
        private System.Windows.Forms.BindingSource tblCourseBindingSource;
        private dbCollageManagementSyatemDataSetTableAdapters.tblCourseTableAdapter tblCourseTableAdapter;
    }
}