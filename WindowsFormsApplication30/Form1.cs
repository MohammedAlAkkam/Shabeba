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

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=YAZAN;Integrated Security=True");
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            connection.Open();
            string cmdString = @"Insert into Member values(@ID,N@Name)";
            SqlCommand cmd = new SqlCommand(cmdString, connection);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtId.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.ExecuteNonQuery();

        string message = " تم إضافة العضو ";
            MessageBox.Show(message + txtName.Text);
            connection.Close();
            txtName.Clear();
            txtAddress.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Member",connection);
            connection.Open();
            SqlDataReader data = cmd.ExecuteReader();
            DataTable Member = new DataTable();
            Member.Load(data);
            dataGridView1.DataSource = Member;
            connection.Close();
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
            if (!char.IsLetter(e.KeyChar) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            //sdsada
        }
    }
}
