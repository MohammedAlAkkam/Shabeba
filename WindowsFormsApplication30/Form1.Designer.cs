namespace WindowsFormsApplication30
{
    partial class Form1
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtMother = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSchools = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(46, 140);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 34);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(440, 250);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(180, 34);
            this.txtPhoneNumber.TabIndex = 0;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtMother
            // 
            this.txtMother.Location = new System.Drawing.Point(440, 50);
            this.txtMother.Margin = new System.Windows.Forms.Padding(6);
            this.txtMother.Name = "txtMother";
            this.txtMother.Size = new System.Drawing.Size(180, 34);
            this.txtMother.TabIndex = 0;
            this.txtMother.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(440, 140);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 34);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(802, 140);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 34);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(802, 244);
            this.txtFather.Margin = new System.Windows.Forms.Padding(6);
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(180, 34);
            this.txtFather.TabIndex = 0;
            this.txtFather.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(802, 50);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 34);
            this.txtId.TabIndex = 1;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1030, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم العضو";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1026, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "الاسم الأول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1026, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم الاب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "اسم الام";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "رقم الهاتف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "عنوان السكن";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "الكنية";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "تاريخ لأنتساب";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "اسم المدرسة";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(663, 333);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(319, 67);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "لا يوجد وصف";
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1037, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "الوصف";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(46, 53);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(180, 34);
            this.dtp.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.FatherName,
            this.MotherName,
            this.LastName,
            this.PhoneNumber,
            this.AffDate,
            this.Address,
            this.SchoolName,
            this.Description});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 415);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1172, 275);
            this.dgv.TabIndex = 10;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "رقم العضو";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 132;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "الاسم";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 89;
            // 
            // FatherName
            // 
            this.FatherName.HeaderText = "اسم الأب";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            this.FatherName.Width = 118;
            // 
            // MotherName
            // 
            this.MotherName.HeaderText = "اسم الأم";
            this.MotherName.Name = "MotherName";
            this.MotherName.ReadOnly = true;
            this.MotherName.Width = 112;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "الكنية";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 88;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "رقم الهاتف";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 133;
            // 
            // AffDate
            // 
            this.AffDate.HeaderText = "تاريخ الانتساب";
            this.AffDate.Name = "AffDate";
            this.AffDate.ReadOnly = true;
            this.AffDate.Width = 166;
            // 
            // Address
            // 
            this.Address.HeaderText = "العنوان";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 103;
            // 
            // SchoolName
            // 
            this.SchoolName.HeaderText = "اسم المدرسة";
            this.SchoolName.Name = "SchoolName";
            this.SchoolName.ReadOnly = true;
            this.SchoolName.Width = 156;
            // 
            // Description
            // 
            this.Description.HeaderText = "الوصف";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 99;
            // 
            // cbxSchools
            // 
            this.cbxSchools.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxSchools.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSchools.FormattingEnabled = true;
            this.cbxSchools.Location = new System.Drawing.Point(46, 248);
            this.cbxSchools.Name = "cbxSchools";
            this.cbxSchools.Size = new System.Drawing.Size(180, 34);
            this.cbxSchools.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 690);
            this.Controls.Add(this.cbxSchools);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtFather);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMother);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtMother;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbxSchools;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

