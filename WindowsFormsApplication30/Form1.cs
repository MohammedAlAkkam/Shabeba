using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using static DataAccess.HelperFunctions;
using System.Text.RegularExpressions;
using System.Dynamic;
using Shabeba;

namespace WindowsFormsApplication30
{
    public partial class FrmMembers : UserControl
    {
        public FrmMembers()
        {
            InitializeComponent();
        }

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

        private IList<DataAccess.MemberMapping> LoadFrmMembers ()
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
        private void Form1_Load(object sender, EventArgs e)
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
        private void NumberValid(object sender , KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(char.IsControl(e.KeyChar)) &&!char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (IDbConnection dbConnection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True"))
            {
                string name = txtName.Text;
                string insert = "insert into [Members] values (@Id,@FirstName,@FatherName,@MotherName,@LastName,@PhoneNumber,@AffiliationDate,@Address,@SchoolId,@Description)";
                DataAccess.Member member = new DataAccess.Member();
                string Months = dtp.Value.Month.ToString();
                string Days = dtp.Value.Day.ToString();
                string Year = dtp.Value.Year.ToString();
                member.FillMember(Convert.ToInt32(txtId.Text), Regex.Replace(txtName.Text, @"\s+", " "),
                    Regex.Replace(txtFather.Text, @"\s+", " "), Regex.Replace(txtMother.Text, @"\s+", " "),
                    Regex.Replace(txtLastName.Text, @"\s+", " "), Regex.Replace(txtPhoneNumber.Text, @"\s+", ""), $"{Year}-{Months}-{Days}", Regex.Replace(txtAddress.Text, @"\s+", " "), (int)cbxSchools.SelectedValue,Regex.Replace(txtDescription.Text,@"\s+"," "));
                dbConnection.Execute(insert, member);
            }
            Filldgv(ToDataTable(LoadFrmMembers()), dgv);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Clear(); txtMother.Clear();
            txtName.Clear(); txtLastName.Clear();
            txtFather.Clear(); txtPhoneNumber.Clear();
            dtp.Value = DateTime.Now;
            txtAddress.Clear(); txtDescription.Text = "لا يوجد وصف";
        }

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
    }
}
