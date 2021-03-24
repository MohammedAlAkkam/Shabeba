using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Data.SqlClient;
using Dapper;
using DataAccess;
namespace Shabeba
{
    public partial class School : Form
    {
        public School()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1100, 400);
        }
        private static DataTable GetSchools()
        {
            SqlConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM [المدارس]", dbConnection);
            dbConnection.Open();
            SqlDataReader data = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(data);
            dbConnection.Close();
            return dt;

        }
        private void ValidControl()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("يرجى ادخال رقم المدرسة");
                return;
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("يرجى اسم المدرسة");
                return;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("ادخل عنوان المدرسة");
                return;
            }
            else if (txtNameManager.Text == "")
            {
                MessageBox.Show("ادخل اسم المدير");
                return;
            }
            else if (txtNumberOfManager.Text == "ادخل رقم المدير")
            {
                MessageBox.Show("ادخل اسم المدرسة");
                return;


            }
        }
        private void School_Load(object sender, EventArgs e)
        {

            dgv.Rows.Clear();
            dgv.DataSource = GetSchools();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (IDbConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True"))
            {
                string name = txtName.Text;
                bool exist = dbConnection.ExecuteScalar<bool>("select count(1) from [المدارس] where [اسم المدرسة] = @name)", new { name});
                if (exist)
                {
                    MessageBox.Show("Exist");
                    return;
                }
                string insert = "insert into [المدارس] values (@id,@name,@Address,@Manager,@ManagerPhone,@SchoolPhone,@NumberOfMembers)";
                DataAccess.School schoole = new DataAccess.School();
                schoole.FillData(Convert.ToInt32(txtId.Text), txtName.Text, txtAddress.Text, txtNameManager.Text, txtNumberOfManager.Text, txtShcoolPhone.Text, 0);
                var resutl = dbConnection.Execute(insert, schoole);
            }

            dgv.DataSource = GetSchools();
            btnReset.PerformClick();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtNameManager.Clear();
            txtNumberOfManager.Clear();
            txtShcoolPhone.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
