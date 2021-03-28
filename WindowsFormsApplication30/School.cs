using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using DataAccess;
using static DataAccess.HelperFunctions;
using System.Text.RegularExpressions;
using WindowsFormsApplication30;

namespace Shabeba
{
    public partial class School : UserControl
    {
        public School()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1100, 400);
        }
        private static string connectionstring = @"Data Source =.; Initial Catalog = Shabeba; Integrated Security = True";
        
        public static DataTable GetSchools()
        {
            string sql = "SELECT * FROM Schools";
            List<DataAccess.School> schools = new List<DataAccess.School>();
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                schools = connection.Query<DataAccess.School>(sql).ToList();
                schools.ForEach(item => { 
                item.NumberOfMembers = connection.QueryFirst<int>("SELECT COUNT(SchoolId) FROM [Members] WHERE SchoolId=@Id", new { item.Id });
                });
            }
           
            return ToDataTable(schools);
        }
        private bool ValidControl()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ادخل رقم المدرسة","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("ادخل اسم المدرسة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("ادخل عنوان المدرسة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtNameManager.Text == "")
            {
                MessageBox.Show("ادخل اسم المدير", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtNumberOfManager.Text == "ادخل رقم المدير")
            {
                MessageBox.Show("ادخل اسم المدرسة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        private void School_Load(object sender, EventArgs e)
        {
            Filldgv(GetSchools(),dgv);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidControl())
                return;
            else
            {
                using (IDbConnection dbConnection = new SqlConnection(connectionstring))
                {
                    string name = txtName.Text;
                    bool exist = dbConnection.ExecuteScalar<bool>("select count(1) from Schools where name = @name", new { name });
                    if (exist)
                    {
                        MessageBox.Show("المدرسة موجودة بالفعل");
                        return;
                    }
                    string insert = "insert into [Schools] values (@id,@name,@Address,@Manager,@ManagerPhone,@SchoolPhone)";
                    DataAccess.School schoole = new DataAccess.School();
                    schoole.FillData(Convert.ToInt32(txtId.Text), Regex.Replace(txtName.Text, @"\s+", " "), Regex.Replace(txtAddress.Text, @"\s+", " "), Regex.Replace(txtNameManager.Text, @"\s+", " "), txtNumberOfManager.Text, txtShcoolPhone.Text);
                    dbConnection.Execute(insert, schoole);
                }
                string namemessage = txtName.Text;
                btnReset.PerformClick();
                Filldgv(GetSchools(),dgv);
                FrmMembers frm = new FrmMembers();
                
                MessageBox.Show($"تم إضافة مدرسة {namemessage} ");
            }
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtId_Validation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
            txtId.ReadOnly = false;
            btnAdd.Enabled = true;
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtNameManager.Clear();
            txtNumberOfManager.Clear();
            txtShcoolPhone.Clear();
            txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidControl())
                return;
            {
                txtId.ReadOnly = false;
                btnAdd.Enabled = true;

                SqlConnection connection = new SqlConnection(connectionstring);
                try
                {
                    string UpdateCommand = "UPDATE [Schools] SET name=@name ,address=@address," +
                        "manager=@manager,managerPhone=@managerPhone," +
                        "schoolPhone=@schoolPhone WHERE id =@id";
                    SqlCommand cmd = new SqlCommand(UpdateCommand, connection);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@manager", txtNameManager.Text);
                    cmd.Parameters.AddWithValue("@managerPhone", txtNumberOfManager.Text);
                    cmd.Parameters.AddWithValue("@schoolPhone", txtShcoolPhone.Text);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    Filldgv(GetSchools(),dgv);
                    MessageBox.Show("تم إجاء التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                Filldgv(GetSchools(),dgv);
            else
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                string search = Regex.Replace(txtSearch.Text, @"\s+", " ");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Schools WHERE [name] like N'%" + search + "%'", connection);
                cmd.Parameters.AddWithValue("@name", txtSearch.Text);
                connection.Open();
                SqlDataReader data = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(data);
                Filldgv(dt,dgv);
                connection.Close();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.ReadOnly = true;
            btnAdd.Enabled = false;
            txtId.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtAddress.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtNameManager.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtNumberOfManager.Text = dgv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtShcoolPhone.Text = dgv.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد جذف هذا السجل", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                string DeleteCommand = "DELETE FROM [Schools] WHERE id = @id";
                SqlCommand cmd = new SqlCommand(DeleteCommand, connection);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                Filldgv(GetSchools(),dgv);
                btnReset.PerformClick();
                MessageBox.Show("تمت عملية الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnReset.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
