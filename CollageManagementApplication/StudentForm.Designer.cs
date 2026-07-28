namespace CollageManagementApplication
{
    partial class StudentForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbDateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbTotalRecords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudentRefresh = new System.Windows.Forms.Button();
            this.btnStudentView = new System.Windows.Forms.Button();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentAddnew = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtbDateTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 44);
            this.panel2.TabIndex = 1;
            // 
            // txtbDateTime
            // 
            this.txtbDateTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbDateTime.Location = new System.Drawing.Point(745, 12);
            this.txtbDateTime.Name = "txtbDateTime";
            this.txtbDateTime.Size = new System.Drawing.Size(238, 20);
            this.txtbDateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(839, 95);
            this.txtbSearch.Multiline = true;
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(144, 33);
            this.txtbSearch.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(844, 323);
            this.dataGridView1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(653, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 20);
            this.button6.TabIndex = 6;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(749, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 20);
            this.button7.TabIndex = 6;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtbTotalRecords);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(103, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 33);
            this.panel3.TabIndex = 7;
            // 
            // txtbTotalRecords
            // 
            this.txtbTotalRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbTotalRecords.Location = new System.Drawing.Point(120, 8);
            this.txtbTotalRecords.Name = "txtbTotalRecords";
            this.txtbTotalRecords.Size = new System.Drawing.Size(100, 20);
            this.txtbTotalRecords.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Records :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(58, 543);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 183);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::CollageManagementApplication.Properties.Resources.User_Icon_Vector_Illustration_In;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(3, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(98, 95);
            this.panel6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Roll No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Details";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(543, 543);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(465, 183);
            this.panel5.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "DOB:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Semester:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Program:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CollageManagementApplication.Properties.Resources.download__6__Photoroom__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(983, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 33);
            this.panel1.TabIndex = 4;
            // 
            // btnStudentRefresh
            // 
            this.btnStudentRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStudentRefresh.Image = global::CollageManagementApplication.Properties.Resources.Reset_icon_in_Ice_Cream_Style_Ph;
            this.btnStudentRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentRefresh.Location = new System.Drawing.Point(616, 95);
            this.btnStudentRefresh.Name = "btnStudentRefresh";
            this.btnStudentRefresh.Size = new System.Drawing.Size(144, 33);
            this.btnStudentRefresh.TabIndex = 2;
            this.btnStudentRefresh.Text = "Refresh";
            this.btnStudentRefresh.UseVisualStyleBackColor = true;
            // 
            // btnStudentView
            // 
            this.btnStudentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStudentView.Image = global::CollageManagementApplication.Properties.Resources.download__8__Photoroom__3_;
            this.btnStudentView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentView.Location = new System.Drawing.Point(466, 95);
            this.btnStudentView.Name = "btnStudentView";
            this.btnStudentView.Size = new System.Drawing.Size(144, 33);
            this.btnStudentView.TabIndex = 2;
            this.btnStudentView.Text = "View";
            this.btnStudentView.UseVisualStyleBackColor = true;
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStudentEdit.Image = global::CollageManagementApplication.Properties.Resources.app_icon_jfif__1_;
            this.btnStudentEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentEdit.Location = new System.Drawing.Point(162, 95);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Size = new System.Drawing.Size(144, 33);
            this.btnStudentEdit.TabIndex = 2;
            this.btnStudentEdit.Text = "Edit";
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStudentDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentDelete.Location = new System.Drawing.Point(314, 95);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(144, 33);
            this.btnStudentDelete.TabIndex = 2;
            this.btnStudentDelete.Text = "Enroll Student";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            // 
            // btnStudentAddnew
            // 
            this.btnStudentAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAddnew.Image = global::CollageManagementApplication.Properties.Resources.download__5__Photoroom__1_;
            this.btnStudentAddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentAddnew.Location = new System.Drawing.Point(12, 95);
            this.btnStudentAddnew.Name = "btnStudentAddnew";
            this.btnStudentAddnew.Size = new System.Drawing.Size(144, 33);
            this.btnStudentAddnew.TabIndex = 2;
            this.btnStudentAddnew.Text = "Add New ";
            this.btnStudentAddnew.UseVisualStyleBackColor = true;
            this.btnStudentAddnew.Click += new System.EventHandler(this.btnStudentAddnew_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 758);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.btnStudentRefresh);
            this.Controls.Add(this.btnStudentView);
            this.Controls.Add(this.btnStudentEdit);
            this.Controls.Add(this.btnStudentDelete);
            this.Controls.Add(this.btnStudentAddnew);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDateTime;
        private System.Windows.Forms.Button btnStudentAddnew;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentView;
        private System.Windows.Forms.Button btnStudentRefresh;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbTotalRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}