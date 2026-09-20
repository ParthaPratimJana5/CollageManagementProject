namespace CollageManagementApplication
{
    partial class Faculty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchFaculty = new System.Windows.Forms.TextBox();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalRecords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshFaculty = new System.Windows.Forms.Button();
            this.btnDeleteFaculty = new System.Windows.Forms.Button();
            this.btnEditFacuty = new System.Windows.Forms.Button();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Management";
            // 
            // txtSearchFaculty
            // 
            this.txtSearchFaculty.Location = new System.Drawing.Point(721, 95);
            this.txtSearchFaculty.Multiline = true;
            this.txtSearchFaculty.Name = "txtSearchFaculty";
            this.txtSearchFaculty.Size = new System.Drawing.Size(264, 33);
            this.txtSearchFaculty.TabIndex = 2;
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaculty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Location = new System.Drawing.Point(12, 183);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.Size = new System.Drawing.Size(1037, 468);
            this.dgvFaculty.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtTotalRecords);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 710);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 48);
            this.panel3.TabIndex = 5;
            // 
            // txtTotalRecords
            // 
            this.txtTotalRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalRecords.Location = new System.Drawing.Point(209, 10);
            this.txtTotalRecords.Multiline = true;
            this.txtTotalRecords.Name = "txtTotalRecords";
            this.txtTotalRecords.Size = new System.Drawing.Size(226, 31);
            this.txtTotalRecords.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Records :";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CollageManagementApplication.Properties.Resources.download__6__Photoroom__1_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(985, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 33);
            this.panel2.TabIndex = 3;
            // 
            // btnRefreshFaculty
            // 
            this.btnRefreshFaculty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefreshFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefreshFaculty.Image = global::CollageManagementApplication.Properties.Resources.Reset_icon_in_Ice_Cream_Style_Ph;
            this.btnRefreshFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshFaculty.Location = new System.Drawing.Point(312, 95);
            this.btnRefreshFaculty.Name = "btnRefreshFaculty";
            this.btnRefreshFaculty.Size = new System.Drawing.Size(144, 33);
            this.btnRefreshFaculty.TabIndex = 1;
            this.btnRefreshFaculty.Text = "Refresh";
            this.btnRefreshFaculty.UseVisualStyleBackColor = false;
            this.btnRefreshFaculty.Click += new System.EventHandler(this.btnRefreshFaculty_Click);
            // 
            // btnDeleteFaculty
            // 
            this.btnDeleteFaculty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteFaculty.Image = global::CollageManagementApplication.Properties.Resources.Delete_free_icons_designed_by_IY;
            this.btnDeleteFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFaculty.Location = new System.Drawing.Point(480, 95);
            this.btnDeleteFaculty.Name = "btnDeleteFaculty";
            this.btnDeleteFaculty.Size = new System.Drawing.Size(144, 33);
            this.btnDeleteFaculty.TabIndex = 1;
            this.btnDeleteFaculty.Text = "Delete";
            this.btnDeleteFaculty.UseVisualStyleBackColor = false;
            // 
            // btnEditFacuty
            // 
            this.btnEditFacuty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditFacuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditFacuty.Image = global::CollageManagementApplication.Properties.Resources.download__7__Photoroom__1_;
            this.btnEditFacuty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFacuty.Location = new System.Drawing.Point(162, 95);
            this.btnEditFacuty.Name = "btnEditFacuty";
            this.btnEditFacuty.Size = new System.Drawing.Size(144, 33);
            this.btnEditFacuty.TabIndex = 1;
            this.btnEditFacuty.Text = "Edit";
            this.btnEditFacuty.UseVisualStyleBackColor = false;
            this.btnEditFacuty.Click += new System.EventHandler(this.btnEditFacuty_Click);
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddFaculty.Image = global::CollageManagementApplication.Properties.Resources.download__5__Photoroom__1_;
            this.btnAddFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFaculty.Location = new System.Drawing.Point(12, 95);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(144, 33);
            this.btnAddFaculty.TabIndex = 1;
            this.btnAddFaculty.Text = "Add New";
            this.btnAddFaculty.UseVisualStyleBackColor = false;
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1051, 758);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvFaculty);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSearchFaculty);
            this.Controls.Add(this.btnRefreshFaculty);
            this.Controls.Add(this.btnDeleteFaculty);
            this.Controls.Add(this.btnEditFacuty);
            this.Controls.Add(this.btnAddFaculty);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Faculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.Faculty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.Button btnEditFacuty;
        private System.Windows.Forms.Button btnDeleteFaculty;
        private System.Windows.Forms.Button btnRefreshFaculty;
        private System.Windows.Forms.TextBox txtSearchFaculty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotalRecords;
        private System.Windows.Forms.Label label2;
    }
}