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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.cmbPayMode = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbPaymentPurpose = new System.Windows.Forms.ComboBox();
            this.btnCollectPayment = new System.Windows.Forms.Button();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.txtPaymentDiscription = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbCourseFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalFees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemainingBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThisPayment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAfterPayemntDue = new System.Windows.Forms.TextBox();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.pictureBoxStudentInfo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
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
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fees Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(835, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // dtpFeesManagement
            // 
            this.dtpFeesManagement.Enabled = false;
            this.dtpFeesManagement.Location = new System.Drawing.Point(889, 12);
            this.dtpFeesManagement.Name = "dtpFeesManagement";
            this.dtpFeesManagement.Size = new System.Drawing.Size(129, 20);
            this.dtpFeesManagement.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(28, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Filter By Course";
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(163, 87);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(246, 21);
            this.cmbStudentName.TabIndex = 4;
            this.cmbStudentName.Text = "Select Student";
            this.cmbStudentName.SelectedIndexChanged += new System.EventHandler(this.cmbStudentName_SelectedIndexChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.Enabled = false;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(424, 85);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 4;
            this.cmbCourse.Text = "Select to Shortlist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(510, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "FEE SUMMARY";
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
            this.panel5.Controls.Add(this.txtPayAmount);
            this.panel5.Controls.Add(this.txtPaymentDiscription);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Location = new System.Drawing.Point(14, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 331);
            this.panel5.TabIndex = 6;
            // 
            // dtpPayment
            // 
            this.dtpPayment.Location = new System.Drawing.Point(181, 151);
            this.dtpPayment.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(138, 20);
            this.dtpPayment.TabIndex = 8;
            this.dtpPayment.Value = new System.DateTime(2026, 8, 12, 0, 0, 0, 0);
            // 
            // cmbPayMode
            // 
            this.cmbPayMode.FormattingEnabled = true;
            this.cmbPayMode.Location = new System.Drawing.Point(181, 15);
            this.cmbPayMode.Name = "cmbPayMode";
            this.cmbPayMode.Size = new System.Drawing.Size(145, 21);
            this.cmbPayMode.TabIndex = 7;
            this.cmbPayMode.Text = "Select Mode of Payment";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 24);
            this.label23.TabIndex = 6;
            this.label23.Text = "Payment Mode:";
            // 
            // cmbPaymentPurpose
            // 
            this.cmbPaymentPurpose.FormattingEnabled = true;
            this.cmbPaymentPurpose.Location = new System.Drawing.Point(181, 55);
            this.cmbPaymentPurpose.Name = "cmbPaymentPurpose";
            this.cmbPaymentPurpose.Size = new System.Drawing.Size(145, 21);
            this.cmbPaymentPurpose.TabIndex = 5;
            this.cmbPaymentPurpose.Text = "Select Payment Purpose";
            // 
            // btnCollectPayment
            // 
            this.btnCollectPayment.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCollectPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCollectPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectPayment.ForeColor = System.Drawing.Color.White;
            this.btnCollectPayment.Image = global::CollageManagementApplication.Properties.Resources.result;
            this.btnCollectPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollectPayment.Location = new System.Drawing.Point(7, 272);
            this.btnCollectPayment.Name = "btnCollectPayment";
            this.btnCollectPayment.Size = new System.Drawing.Size(296, 42);
            this.btnCollectPayment.TabIndex = 1;
            this.btnCollectPayment.Text = "Collect Payment";
            this.btnCollectPayment.UseVisualStyleBackColor = false;
            this.btnCollectPayment.Click += new System.EventHandler(this.btnCollectPayment_Click_1);
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
            // txtPayAmount
            // 
            this.txtPayAmount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPayAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPayAmount.Location = new System.Drawing.Point(181, 97);
            this.txtPayAmount.Multiline = true;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(145, 26);
            this.txtPayAmount.TabIndex = 3;
            this.txtPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPayAmount.TextChanged += new System.EventHandler(this.txtPayAmount_TextChanged);
            // 
            // txtPaymentDiscription
            // 
            this.txtPaymentDiscription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPaymentDiscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPaymentDiscription.Location = new System.Drawing.Point(185, 197);
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
            this.label21.Location = new System.Drawing.Point(2, 215);
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
            this.label20.Location = new System.Drawing.Point(3, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Date:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Payable Amount:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Payment Purpose:";
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
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.label17.Location = new System.Drawing.Point(20, 387);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "PAYMENT";
            // 
            // cmbCourseFilter
            // 
            this.cmbCourseFilter.FormattingEnabled = true;
            this.cmbCourseFilter.Location = new System.Drawing.Point(160, 52);
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
            this.label7.Location = new System.Drawing.Point(1, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Fees";
            // 
            // txtTotalFees
            // 
            this.txtTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFees.Location = new System.Drawing.Point(239, 15);
            this.txtTotalFees.Name = "txtTotalFees";
            this.txtTotalFees.Size = new System.Drawing.Size(167, 22);
            this.txtTotalFees.TabIndex = 7;
            this.txtTotalFees.TextChanged += new System.EventHandler(this.txtTotalFees_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(1, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Paid till the day";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Enabled = false;
            this.txtTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPaid.Location = new System.Drawing.Point(239, 64);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(167, 22);
            this.txtTotalPaid.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Remaining Balance";
            // 
            // txtRemainingBalance
            // 
            this.txtRemainingBalance.Enabled = false;
            this.txtRemainingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingBalance.Location = new System.Drawing.Point(239, 100);
            this.txtRemainingBalance.Name = "txtRemainingBalance";
            this.txtRemainingBalance.Size = new System.Drawing.Size(167, 22);
            this.txtRemainingBalance.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(1, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "This Payment";
            // 
            // txtThisPayment
            // 
            this.txtThisPayment.Enabled = false;
            this.txtThisPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThisPayment.Location = new System.Drawing.Point(239, 130);
            this.txtThisPayment.Name = "txtThisPayment";
            this.txtThisPayment.Size = new System.Drawing.Size(167, 22);
            this.txtThisPayment.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(1, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "After Payment Due";
            // 
            // txtAfterPayemntDue
            // 
            this.txtAfterPayemntDue.Enabled = false;
            this.txtAfterPayemntDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfterPayemntDue.Location = new System.Drawing.Point(239, 162);
            this.txtAfterPayemntDue.Name = "txtAfterPayemntDue";
            this.txtAfterPayemntDue.Size = new System.Drawing.Size(167, 22);
            this.txtAfterPayemntDue.TabIndex = 7;
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(392, 417);
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.Size = new System.Drawing.Size(659, 331);
            this.dgvPaymentHistory.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.label12.Location = new System.Drawing.Point(388, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "PAYMENT HISTORY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.label13.Location = new System.Drawing.Point(10, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(255, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "STUDENT INFORMATION";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(12, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Student ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(12, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Student Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(12, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Guardian Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.Location = new System.Drawing.Point(12, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "Course";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label25.Location = new System.Drawing.Point(12, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 20);
            this.label25.TabIndex = 1;
            this.label25.Text = "Department";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentId.Enabled = false;
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(154, 13);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(167, 15);
            this.txtStudentId.TabIndex = 7;
            this.txtStudentId.Text = "Test";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(154, 46);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(167, 15);
            this.txtStudentName.TabIndex = 7;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuardianName.Enabled = false;
            this.txtGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianName.Location = new System.Drawing.Point(154, 82);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(167, 15);
            this.txtGuardianName.TabIndex = 7;
            // 
            // txtCourse
            // 
            this.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourse.Enabled = false;
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(154, 112);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(167, 15);
            this.txtCourse.TabIndex = 7;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartment.Enabled = false;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(154, 144);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(167, 15);
            this.txtDepartment.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label26.Location = new System.Drawing.Point(12, 174);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Enabled = false;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(154, 172);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(167, 15);
            this.txtYear.TabIndex = 7;
            // 
            // pictureBoxStudentInfo
            // 
            this.pictureBoxStudentInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxStudentInfo.Location = new System.Drawing.Point(343, 31);
            this.pictureBoxStudentInfo.Name = "pictureBoxStudentInfo";
            this.pictureBoxStudentInfo.Size = new System.Drawing.Size(118, 138);
            this.pictureBoxStudentInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudentInfo.TabIndex = 9;
            this.pictureBoxStudentInfo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBoxStudentInfo);
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.txtDepartment);
            this.panel2.Controls.Add(this.txtCourse);
            this.panel2.Controls.Add(this.txtGuardianName);
            this.panel2.Controls.Add(this.txtStudentName);
            this.panel2.Controls.Add(this.txtStudentId);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(12, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 206);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblWarning);
            this.panel3.Controls.Add(this.txtAfterPayemntDue);
            this.panel3.Controls.Add(this.txtThisPayment);
            this.panel3.Controls.Add(this.txtRemainingBalance);
            this.panel3.Controls.Add(this.txtTotalPaid);
            this.panel3.Controls.Add(this.txtTotalFees);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(514, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 208);
            this.panel3.TabIndex = 11;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(236, 40);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(195, 13);
            this.lblWarning.TabIndex = 8;
            this.lblWarning.Text = "Enter Total Fees to Calculate Remaning";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CollageManagementApplication.Properties.Resources.Matangini_Institute_Logo_Redesign_png_tuxpi;
            this.pictureBox1.Location = new System.Drawing.Point(889, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 758);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvPaymentHistory);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cmbCourseFilter);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFeesManagement;
        private System.Windows.Forms.ComboBox cmbStudentName;
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
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.TextBox txtPaymentDiscription;
        private System.Windows.Forms.ComboBox cmbPaymentPurpose;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.ComboBox cmbPayMode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbCourseFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemainingBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThisPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAfterPayemntDue;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.PictureBox pictureBoxStudentInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWarning;
    }
}