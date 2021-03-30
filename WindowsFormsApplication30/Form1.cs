using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using static DataAccess.HelperFunctions;
using System.Text.RegularExpressions;

namespace ShabebaMain
{
    public partial class FrmMembers : UserControl
    {
        public FrmMembers()
        {
            InitializeComponent();
        }
        Shabeba.School sch = new Shabeba.School();
        public bool ControlIsValid()
        {
            bool answer = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text != "")
                        answer = true;
                    else
                    {
                        answer = false;
                    }
                }
            }
            return answer;
        }

        public IList<DataAccess.MemberMapping> LoadFrmMembers()
        {
            string sql = "EXEC GetAllMembers";
            IList<DataAccess.MemberMapping> members = new List<DataAccess.MemberMapping>();
            List<DataAccess.School> schools = new List<DataAccess.School>();
            using (IDbConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True"))
            {
                members = dbConnection.Query<DataAccess.MemberMapping>(sql).ToList();
                schools = dbConnection.Query<DataAccess.School>("SELECT * FROM Schools").ToList();
            }
            cbxSchools.DataSource = schools;
            cbxSchools.ValueMember = "Id";
            cbxSchools.DisplayMember = "name";
            cbxSchools.AutoCompleteSource = AutoCompleteSource.ListItems;
            return members;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Filldgv(ToDataTable(LoadFrmMembers()), dgv);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void NumberValid(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(char.IsControl(e.KeyChar)) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Completed
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.ReadOnly = true;
            btnAdd.Enabled = false;
            txtId.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtFather.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtMother.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtLastName.Text = dgv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPhoneNumber.Text = dgv.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            dtp.Value = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells[6].Value);
            txtAddress.Text = dgv.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            cbxSchools.Text = dgv.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            txtDescription.Text = dgv.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
        }
        //Completed
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ControlIsValid())
                MessageBox.Show("يرجى تعبئة الحقول الفارغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (IDbConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True"))
                {
                    int Id = Convert.ToInt32(txtName.Text);
                    bool exist = dbConnection.ExecuteScalar<bool>("select count(1) from Schools where name = @name", new { Id });
                    if (exist)
                    {
                        MessageBox.Show("يرجى تغيير رقم العضو", "");
                        return;
                    }
                    string insert = "insert into [Members] values (@Id,@FirstName,@FatherName,@MotherName,@LastName,@PhoneNumber,@AffiliationDate,@Address,@SchoolId,@Description)";
                    DataAccess.Member member = new DataAccess.Member();
                    string Months = dtp.Value.Month.ToString();
                    string Days = dtp.Value.Day.ToString();
                    string Year = dtp.Value.Year.ToString();
                    member.FillMember(Convert.ToInt32(txtId.Text), Regex.Replace(txtName.Text, @"\s+", " "),
                        Regex.Replace(txtFather.Text, @"\s+", " "), Regex.Replace(txtMother.Text, @"\s+", " "),
                        Regex.Replace(txtLastName.Text, @"\s+", " "), Regex.Replace(txtPhoneNumber.Text, @"\s+", ""), $"{Year}-{Months}-{Days}", Regex.Replace(txtAddress.Text, @"\s+", " "), (int)cbxSchools.SelectedValue, Regex.Replace(txtDescription.Text, @"\s+", " "));
                    dbConnection.Execute(insert, member);
                }
                Filldgv(ToDataTable(LoadFrmMembers()), dgv);
                Filldgv(sch.GetSchools(),sch.dgv);
                MessageBox.Show("تمت إضافة العضو بنجاح","نجاح",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Clear(); txtMother.Clear();
            txtName.Clear(); txtLastName.Clear();
            txtFather.Clear(); txtPhoneNumber.Clear();
            dtp.Value = DateTime.Now;
            txtAddress.Clear(); txtDescription.Text = "لا يوجد وصف";
            txtId.ReadOnly = false;
            btnAdd.Enabled = true;
        }
        //Completed
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                Filldgv(ToDataTable(LoadFrmMembers()), dgv);
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True");
                string search = Regex.Replace(txtSearch.Text, @"\s+", " ");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE [FirstName] like N'%" + search + "%'", connection);
                cmd.Parameters.AddWithValue("@name", txtSearch.Text);
                connection.Open();
                SqlDataReader data = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(data);
                Filldgv(dt, dgv);
                connection.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            btnAdd.Enabled = true;
            string UpdateCommand = @"UPDATE [Members] SET FirstName=@FirstName ,FatherName=@FatherName , MotherName=@MotherName,LastName=@LastName,PhoneNumber=@PhoneNumber,AffiliationDate=@AffiliationDate,Address=@Address,SchoolId=@SchoolId,Description=@Description WHERE Id=@Id";
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(UpdateCommand, connection);
            cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
            cmd.Parameters.AddWithValue("@FatherName", txtFather.Text);
            cmd.Parameters.AddWithValue("@MotherName", txtMother.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            string Months = dtp.Value.Month.ToString();
            string Days = dtp.Value.Day.ToString();
            string Year = dtp.Value.Year.ToString();
            cmd.Parameters.AddWithValue("@AffiliationDate", $"{Year}-{Months}-{Days}");
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@SchoolId", Convert.ToInt32(cbxSchools.SelectedValue));
            cmd.Parameters.AddWithValue(@"Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            Filldgv(ToDataTable(LoadFrmMembers()), dgv);
            Filldgv(sch.GetSchools(), sch.dgv);
            btnReset.PerformClick();
            MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Completed
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا السجل", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (IDbConnection dbConnection = new SqlConnection("Data Source =.; Initial Catalog = Shabeba; Integrated Security = True"))
                {
                    int Id = Convert.ToInt32(txtId.Text);
                    dbConnection.Execute("DELETE FROM [Members] Where Id=@Id", new { Id });
                }
                Filldgv(ToDataTable(LoadFrmMembers()), dgv);
                Filldgv(sch.GetSchools(), sch.dgv);
                btnReset.PerformClick();
                MessageBox.Show("تمت عملية الحذف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
