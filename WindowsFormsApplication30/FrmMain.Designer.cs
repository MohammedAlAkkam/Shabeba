namespace Shabeba
{
    partial class FrmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSchools = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frmMembers1 = new ShabebaMain.FrmMembers();
            this.school1 = new Shabeba.School();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSchools);
            this.panel1.Controls.Add(this.btnMembers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1180, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 700);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shabeba.Properties.Resources.Shabeba;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSchools
            // 
            this.btnSchools.FlatAppearance.BorderSize = 0;
            this.btnSchools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchools.Location = new System.Drawing.Point(2, 281);
            this.btnSchools.Name = "btnSchools";
            this.btnSchools.Size = new System.Drawing.Size(147, 67);
            this.btnSchools.TabIndex = 1;
            this.btnSchools.Text = "المدارس";
            this.btnSchools.UseVisualStyleBackColor = true;
            this.btnSchools.Click += new System.EventHandler(this.btnSchools_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.DarkGray;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Location = new System.Drawing.Point(2, 180);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(147, 67);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "الأعضاء";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.frmMembers1);
            this.panel2.Controls.Add(this.school1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 700);
            this.panel2.TabIndex = 1;
            // 
            // frmMembers1
            // 
            this.frmMembers1.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMembers1.Location = new System.Drawing.Point(0, 0);
            this.frmMembers1.Margin = new System.Windows.Forms.Padding(6);
            this.frmMembers1.Name = "frmMembers1";
            this.frmMembers1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frmMembers1.Size = new System.Drawing.Size(1180, 700);
            this.frmMembers1.TabIndex = 1;
            this.frmMembers1.Load += new System.EventHandler(this.frmMembers1_Load);
            // 
            // school1
            // 
            this.school1.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.school1.Location = new System.Drawing.Point(0, 0);
            this.school1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.school1.MinimumSize = new System.Drawing.Size(1100, 400);
            this.school1.Name = "school1";
            this.school1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.school1.Size = new System.Drawing.Size(1180, 700);
            this.school1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private School school1;
        private System.Windows.Forms.Button btnSchools;
        private System.Windows.Forms.Button btnMembers;
        private ShabebaMain.FrmMembers frmMembers1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}