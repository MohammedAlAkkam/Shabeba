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
namespace WindowsFormsApplication30
{
    public partial class Form1 : Form
    {
        public Form1()
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

        static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Shabeba;Integrated Security=True");
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            connection.Open();
            string cmdString = @"Insert into Member (رقم العضو,أسم العضو) values(@رقم العضو@,أسم العضو)";
            SqlCommand cmd = new SqlCommand(cmdString, connection);
            cmd.Parameters.AddWithValue("@رقم العضو", Convert.ToInt32(txtId.Text));
            cmd.Parameters.AddWithValue("@أسم العضو", txtName.Text);
            cmd.ExecuteNonQuery();

        string message = " تم إضافة العضو ";
            MessageBox.Show(message + txtName.Text);
            connection.Close();
            
            
            txtName.Clear();
            txtAddress.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "EXEC GetAllMembers";
            IList<DataAccess.Member> members = new List<DataAccess.Member>();
            List<DataAccess.School> schools = new List<DataAccess.School>();
            using (IDbConnection dbConnection =connection)
            {
                members = dbConnection.Query<DataAccess.Member>(sql).ToList();
                schools = dbConnection.Query<DataAccess.School>("SELECT * FROM Schools").ToList();
            }
            cbxSchools.DataSource = schools;
            cbxSchools.ValueMember = "Id";
            cbxSchools.DisplayMember = "name";
            Filldgv(ToDataTable(members),dgv);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(char.IsControl(e.KeyChar)))
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
