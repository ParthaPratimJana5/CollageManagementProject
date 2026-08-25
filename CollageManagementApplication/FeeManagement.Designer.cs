namespace CollageManagementApplication
{
    partial class FeeManagement
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFeesManagement = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.comboStudentId = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.cmbPayMode = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbPaymentPurpose = new System.Windows.Forms.ComboBox();
            this.btnCollectPayment = new System.Windows.Forms.Button();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtPidAmount = new System.Windows.Forms.TextBox();
            this.txtPaymentDiscription = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbCourseFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFeesManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fees Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(769, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // dtpFeesManagement
            // 
            this.dtpFeesManagement.Location = new System.Drawing.Point(824, 13);
            this.dtpFeesManagement.Name = "dtpFeesManagement";
            this.dtpFeesManagement.Size = new System.Drawing.Size(202, 20);
            this.dtpFeesManagement.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(333, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(27, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Filter By Course";
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(159, 133);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(246, 21);
            this.cmbStudentName.TabIndex = 4;
            this.cmbStudentName.Text = "Select Student";
            this.cmbStudentName.SelectedIndexChanged += new System.EventHandler(this.cmbStudentName_SelectedIndexChanged);
            // 
            // comboStudentId
            // 
            this.comboStudentId.FormattingEnabled = true;
            this.comboStudentId.Location = new System.Drawing.Point(431, 74);
            this.comboStudentId.Name = "comboStudentId";
            this.comboStudentId.Size = new System.Drawing.Size(121, 21);
            this.comboStudentId.TabIndex = 4;
            // 
            // cmbCourse
            // 
            this.cmbCourse.Enabled = false;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(418, 131);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 4;
            this.cmbCourse.Text = "Select to Shortlist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(20, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fee Summary";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dtpPayment);
            this.panel5.Controls.Add(this.cmbPayMode);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.cmbPaymentPurpose);
            this.panel5.Controls.Add(this.btnCollectPayment);
            this.panel5.Controls.Add(this.txtTotalDue);
            this.panel5.Controls.Add(this.txtPidAmount);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.txtPaymentDiscription);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Location = new System.Drawing.Point(675, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 423);
            this.panel5.TabIndex = 6;
            // 
            // dtpPayment
            // 
            this.dtpPayment.Location = new System.Drawing.Point(164, 199);
            this.dtpPayment.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(162, 20);
            this.dtpPayment.TabIndex = 8;
            this.dtpPayment.Value = new System.DateTime(2026, 8, 12, 0, 0, 0, 0);
            // 
            // cmbPayMode
            // 
            this.cmbPayMode.FormattingEnabled = true;
            this.cmbPayMode.Location = new System.Drawing.Point(177, 63);
            this.cmbPayMode.Name = "cmbPayMode";
            this.cmbPayMode.Size = new System.Drawing.Size(145, 21);
            this.cmbPayMode.TabIndex = 7;
            this.cmbPayMode.Text = "Select Mode of Payment";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 24);
            this.label23.TabIndex = 6;
            this.label23.Text = "Payment Mode:";
            // 
            // cmbPaymentPurpose
            // 
            this.cmbPaymentPurpose.FormattingEnabled = true;
            this.cmbPaymentPurpose.Location = new System.Drawing.Point(177, 103);
            this.cmbPaymentPurpose.Name = "cmbPaymentPurpose";
            this.cmbPaymentPurpose.Size = new System.Drawing.Size(145, 21);
            this.cmbPaymentPurpose.TabIndex = 5;
            this.cmbPaymentPurpose.Text = "Select Payment Purpose";
            // 
            // btnCollectPayment
            // 
            this.btnCollectPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.btnCollectPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCollectPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectPayment.ForeColor = System.Drawing.Color.White;
            this.btnCollectPayment.Location = new System.Drawing.Point(17, 320);
            this.btnCollectPayment.Name = "btnCollectPayment";
            this.btnCollectPayment.Size = new System.Drawing.Size(296, 42);
            this.btnCollectPayment.TabIndex = 1;
            this.btnCollectPayment.Text = "Collect Payment";
            this.btnCollectPayment.UseVisualStyleBackColor = false;
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDue.Location = new System.Drawing.Point(203, 389);
            this.txtTotalDue.Multiline = true;
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.Size = new System.Drawing.Size(141, 26);
            this.txtTotalDue.TabIndex = 3;
            // 
            // txtPidAmount
            // 
            this.txtPidAmount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPidAmount.Location = new System.Drawing.Point(177, 145);
            this.txtPidAmount.Multiline = true;
            this.txtPidAmount.Name = "txtPidAmount";
            this.txtPidAmount.Size = new System.Drawing.Size(141, 26);
            this.txtPidAmount.TabIndex = 3;
            this.txtPidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPaymentDiscription
            // 
            this.txtPaymentDiscription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPaymentDiscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPaymentDiscription.Location = new System.Drawing.Point(181, 245);
            this.txtPaymentDiscription.Multiline = true;
            this.txtPaymentDiscription.Name = "txtPaymentDiscription";
            this.txtPaymentDiscription.Size = new System.Drawing.Size(141, 58);
            this.txtPaymentDiscription.TabIndex = 3;
            this.txtPaymentDiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(2, 263);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(173, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "Discription or Notes";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 199);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Date:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Paid Amount:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Payment Purpose :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 389);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(187, 24);
            this.label22.TabIndex = 0;
            this.label22.Text = "Total Due Amount ₹ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(23)))), ((int)(((byte)(61)))));
            this.label17.Location = new System.Drawing.Point(110, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "Payment";
            // 
            // cmbCourseFilter
            // 
            this.cmbCourseFilter.FormattingEnabled = true;
            this.cmbCourseFilter.Location = new System.Drawing.Point(159, 75);
            this.cmbCourseFilter.Name = "cmbCourseFilter";
            this.cmbCourseFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbCourseFilter.TabIndex = 4;
            this.cmbCourseFilter.Text = "Select Course";
            this.cmbCourseFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCourseFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(23, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Fees";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(23, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Paid till the day";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(181, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 7;
            // 
            // FeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 758);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cmbCourseFilter);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.comboStudentId);
            this.Controls.Add(this.cmbStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeManagement";
            this.Load += new System.EventHandler(this.FeeManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFeesManagement;
        private System.Windows.Forms.ComboBox cmbStudentName;
        private System.Windows.Forms.ComboBox comboStudentId;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCollectPayment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPidAmount;
        private System.Windows.Forms.TextBox txtPaymentDiscription;
        private System.Windows.Forms.ComboBox cmbPaymentPurpose;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.ComboBox cmbPayMode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbCourseFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
    }
}