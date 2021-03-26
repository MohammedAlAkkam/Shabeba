﻿
namespace Shabeba
{
    partial class School
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameManager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShcoolPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfManager = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofmanager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneofmanager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneOfSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberofMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم المدرسة";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(805, 32);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 33);
            this.txtId.TabIndex = 1;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(805, 106);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 33);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(997, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المدرسة";
            // 
            // txtNameManager
            // 
            this.txtNameManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNameManager.Location = new System.Drawing.Point(458, 106);
            this.txtNameManager.Margin = new System.Windows.Forms.Padding(6);
            this.txtNameManager.Name = "txtNameManager";
            this.txtNameManager.Size = new System.Drawing.Size(180, 33);
            this.txtNameManager.TabIndex = 7;
            this.txtNameManager.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المدير";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Location = new System.Drawing.Point(458, 32);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 33);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "العنوان";
            // 
            // txtShcoolPhone
            // 
            this.txtShcoolPhone.Location = new System.Drawing.Point(63, 104);
            this.txtShcoolPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtShcoolPhone.Name = "txtShcoolPhone";
            this.txtShcoolPhone.Size = new System.Drawing.Size(180, 33);
            this.txtShcoolPhone.TabIndex = 11;
            this.txtShcoolPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "هاتف المدرسة";
            // 
            // txtNumberOfManager
            // 
            this.txtNumberOfManager.Location = new System.Drawing.Point(63, 30);
            this.txtNumberOfManager.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumberOfManager.Name = "txtNumberOfManager";
            this.txtNumberOfManager.Size = new System.Drawing.Size(180, 33);
            this.txtNumberOfManager.TabIndex = 9;
            this.txtNumberOfManager.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "هاتف المدير";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(927, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(652, 201);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 45);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(342, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(63, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 45);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "مسح";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.nameofmanager,
            this.phoneofmanager,
            this.PhoneOfSchool,
            this.NumberofMember});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 318);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 60;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(1152, 302);
            this.dgv.TabIndex = 16;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(393, 272);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 33);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(749, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "اسم المدرسة";
            // 
            // id
            // 
            this.id.HeaderText = "رقم المدرسة";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 133;
            // 
            // name
            // 
            this.name.HeaderText = "اسم المدرسة";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 138;
            // 
            // address
            // 
            this.address.HeaderText = "العنوان";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 93;
            // 
            // nameofmanager
            // 
            this.nameofmanager.HeaderText = "اسم المدير";
            this.nameofmanager.Name = "nameofmanager";
            this.nameofmanager.ReadOnly = true;
            this.nameofmanager.Width = 120;
            // 
            // phoneofmanager
            // 
            this.phoneofmanager.HeaderText = "هاتف المدير";
            this.phoneofmanager.Name = "phoneofmanager";
            this.phoneofmanager.ReadOnly = true;
            this.phoneofmanager.Width = 131;
            // 
            // PhoneOfSchool
            // 
            this.PhoneOfSchool.HeaderText = "هاتف المدرسة";
            this.PhoneOfSchool.Name = "PhoneOfSchool";
            this.PhoneOfSchool.ReadOnly = true;
            this.PhoneOfSchool.Width = 149;
            // 
            // NumberofMember
            // 
            this.NumberofMember.HeaderText = "عدد الأعضاء";
            this.NumberofMember.Name = "NumberofMember";
            this.NumberofMember.ReadOnly = true;
            this.NumberofMember.Width = 132;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "تصدير إلى جدول اكسيل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // School
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtShcoolPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberOfManager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameManager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "School";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School";
            this.Load += new System.EventHandler(this.School_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShcoolPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofmanager;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneofmanager;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneOfSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberofMember;
        private System.Windows.Forms.Button button1;
    }
}