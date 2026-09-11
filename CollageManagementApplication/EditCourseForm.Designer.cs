namespace CollageManagementApplication
{
    partial class EditCourseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtEditCourseId = new System.Windows.Forms.TextBox();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.cmbCourseOfSubject = new System.Windows.Forms.ComboBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtsubjectName = new System.Windows.Forms.TextBox();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbDepartmentEdit = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSaveDepartment = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 50);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Course";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.cmbDepartment);
            this.panel2.Controls.Add(this.btnSaveCourse);
            this.panel2.Controls.Add(this.txtCourseDuration);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.cmbCourse);
            this.panel2.Controls.Add(this.txtEditCourseId);
            this.panel2.Controls.Add(this.btnSearchByID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 307);
            this.panel2.TabIndex = 9;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(231, 237);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(246, 21);
            this.cmbDepartment.TabIndex = 12;
            this.cmbDepartment.Text = "Select Department";
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCourse.Location = new System.Drawing.Point(175, 264);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(175, 33);
            this.btnSaveCourse.TabIndex = 8;
            this.btnSaveCourse.Text = "Save";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.Location = new System.Drawing.Point(231, 192);
            this.txtCourseDuration.Multiline = true;
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(246, 24);
            this.txtCourseDuration.TabIndex = 9;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(231, 153);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(246, 24);
            this.txtCourseName.TabIndex = 10;
            // 
            // cmbCourse
            // 
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(231, 69);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(246, 24);
            this.cmbCourse.TabIndex = 17;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // txtEditCourseId
            // 
            this.txtEditCourseId.Location = new System.Drawing.Point(231, 108);
            this.txtEditCourseId.Multiline = true;
            this.txtEditCourseId.Name = "txtEditCourseId";
            this.txtEditCourseId.ReadOnly = true;
            this.txtEditCourseId.Size = new System.Drawing.Size(246, 24);
            this.txtEditCourseId.TabIndex = 11;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.Image = global::CollageManagementApplication.Properties.Resources.search_21dp;
            this.btnSearchByID.Location = new System.Drawing.Point(476, 69);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(23, 25);
            this.btnSearchByID.TabIndex = 3;
            this.btnSearchByID.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 232);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Department ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Course Duration (Year)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(23, 153);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(127, 24);
            this.label13.TabIndex = 6;
            this.label13.Text = "Course Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(23, 108);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(93, 24);
            this.label15.TabIndex = 7;
            this.label15.Text = "Course ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(150, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Edit Course Information";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CollageManagementApplication.Properties.Resources.search_21dp;
            this.button1.Location = new System.Drawing.Point(471, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 27);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Subject";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CollageManagementApplication.Properties.Resources.Matangini_Institute_Logo_Redesign_png_tuxpi;
            this.pictureBox1.Location = new System.Drawing.Point(937, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(460, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id Can Not Be Changed";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.btnSaveSubject);
            this.panel3.Controls.Add(this.cmbCourseOfSubject);
            this.panel3.Controls.Add(this.cmbStaff);
            this.panel3.Controls.Add(this.cmbSubject);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtsubjectName);
            this.panel3.Controls.Add(this.txtSubjectId);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(524, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 307);
            this.panel3.TabIndex = 7;
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSubject.Location = new System.Drawing.Point(164, 270);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(175, 33);
            this.btnSaveSubject.TabIndex = 2;
            this.btnSaveSubject.Text = "Save";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // cmbCourseOfSubject
            // 
            this.cmbCourseOfSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseOfSubject.FormattingEnabled = true;
            this.cmbCourseOfSubject.Location = new System.Drawing.Point(226, 188);
            this.cmbCourseOfSubject.Name = "cmbCourseOfSubject";
            this.cmbCourseOfSubject.Size = new System.Drawing.Size(246, 24);
            this.cmbCourseOfSubject.TabIndex = 17;
            // 
            // cmbStaff
            // 
            this.cmbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(226, 228);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(246, 24);
            this.cmbStaff.TabIndex = 17;
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(226, 72);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(246, 24);
            this.cmbSubject.TabIndex = 17;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // txtsubjectName
            // 
            this.txtsubjectName.Location = new System.Drawing.Point(226, 149);
            this.txtsubjectName.Multiline = true;
            this.txtsubjectName.Name = "txtsubjectName";
            this.txtsubjectName.Size = new System.Drawing.Size(246, 24);
            this.txtsubjectName.TabIndex = 2;
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(226, 104);
            this.txtSubjectId.Multiline = true;
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.ReadOnly = true;
            this.txtSubjectId.Size = new System.Drawing.Size(246, 24);
            this.txtSubjectId.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 227);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(44, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Staff";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 187);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 148);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(129, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Subject Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(24, 103);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Subject ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(200, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Edit Subject";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(855, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add another subject";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label28.Location = new System.Drawing.Point(651, 257);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 20);
            this.label28.TabIndex = 20;
            this.label28.Text = "Or";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.cmbDepartmentEdit);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.btnSaveDepartment);
            this.panel4.Controls.Add(this.txtDepartment);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(12, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 220);
            this.panel4.TabIndex = 21;
            // 
            // cmbDepartmentEdit
            // 
            this.cmbDepartmentEdit.FormattingEnabled = true;
            this.cmbDepartmentEdit.Location = new System.Drawing.Point(213, 74);
            this.cmbDepartmentEdit.Name = "cmbDepartmentEdit";
            this.cmbDepartmentEdit.Size = new System.Drawing.Size(246, 21);
            this.cmbDepartmentEdit.TabIndex = 5;
            this.cmbDepartmentEdit.Text = "Select Department";
            this.cmbDepartmentEdit.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentEdit_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(23, 69);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(169, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "Select Department ";
            // 
            // btnSaveDepartment
            // 
            this.btnSaveDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSaveDepartment.Location = new System.Drawing.Point(182, 168);
            this.btnSaveDepartment.Name = "btnSaveDepartment";
            this.btnSaveDepartment.Size = new System.Drawing.Size(175, 33);
            this.btnSaveDepartment.TabIndex = 3;
            this.btnSaveDepartment.Text = "Save";
            this.btnSaveDepartment.UseVisualStyleBackColor = true;
            this.btnSaveDepartment.Click += new System.EventHandler(this.btnSaveDepartment_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(213, 111);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(246, 24);
            this.txtDepartment.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(23, 111);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(163, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Department Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(147, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Edit Department";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1065, 728);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.TextBox txtsubjectName;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.ComboBox cmbCourseOfSubject;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSaveDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbDepartmentEdit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtEditCourseId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}