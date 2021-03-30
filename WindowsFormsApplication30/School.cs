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
using ShabebaMain;
using ClosedXML.Excel;
using System.IO;

namespace Shabeba
{
    public partial class School : UserControl
    {
        public School()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1100, 400);
        }
        private static string connectionstring = @"Data Source =.\sqlexpress; Initial Catalog = Shabeba; Integrated Security = True";
        private bool CheckDB()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                connection.Open();
                return true;
            }
            catch 
            {

                return false;
            }
        }
        private void GenerteDB()
        {
            #region Command
            SqlCommand cmd = new SqlCommand(@"USE [master]
GO
/****** Object:  Database [Shabeba]    Script Date: 3/30/2021 08:45:41 م ******/
CREATE DATABASE[Shabeba]
CONTAINMENT = NONE
ON  PRIMARY
(NAME = N'Shabeba', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shabeba.mdf', SIZE = 8192KB, MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB)
LOG ON
(NAME = N'Shabeba_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shabeba_log.ldf', SIZE = 8192KB, MAXSIZE = 2048GB, FILEGROWTH = 65536KB)
WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE[Shabeba] SET COMPATIBILITY_LEVEL = 100
GO
IF(1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC[Shabeba].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE[Shabeba] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE[Shabeba] SET ANSI_NULLS OFF
GO
ALTER DATABASE[Shabeba] SET ANSI_PADDING OFF
GO
ALTER DATABASE[Shabeba] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE[Shabeba] SET ARITHABORT OFF
GO
ALTER DATABASE[Shabeba] SET AUTO_CLOSE OFF
GO
ALTER DATABASE[Shabeba] SET AUTO_SHRINK OFF
GO
ALTER DATABASE[Shabeba] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE[Shabeba] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE[Shabeba] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE[Shabeba] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE[Shabeba] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE[Shabeba] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE[Shabeba] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE[Shabeba] SET  DISABLE_BROKER
GO
ALTER DATABASE[Shabeba] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE[Shabeba] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE[Shabeba] SET TRUSTWORTHY OFF
GO
ALTER DATABASE[Shabeba] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE[Shabeba] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE[Shabeba] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE[Shabeba] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE[Shabeba] SET RECOVERY FULL
GO
ALTER DATABASE[Shabeba] SET  MULTI_USER
GO
ALTER DATABASE[Shabeba] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE[Shabeba] SET DB_CHAINING OFF
GO
ALTER DATABASE[Shabeba] SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF)
GO
ALTER DATABASE[Shabeba] SET TARGET_RECOVERY_TIME = 60 SECONDS
GO
ALTER DATABASE[Shabeba] SET DELAYED_DURABILITY = DISABLED
GO
EXEC sys.sp_db_vardecimal_storage_format N'Shabeba', N'ON'
GO
ALTER DATABASE[Shabeba] SET QUERY_STORE = OFF
GO
USE[Shabeba]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 3/30/2021 08:45:42 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[Members](
[Id][int] NOT NULL,
[FirstName][nvarchar](50) NOT NULL,
[FatherName][nvarchar](50) NOT NULL,
[MotherName][nvarchar](50) NOT NULL,
[LastName][nvarchar](50) NOT NULL,
[PhoneNumber][nvarchar](50) NOT NULL,
[AffiliationDate][nvarchar](50) NOT NULL,
[Address][nvarchar](50) NOT NULL,
[SchoolId][int] NOT NULL,
[Description][ntext] NOT NULL,
CONSTRAINT[PK_Members] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
GO
/****** Object:  Table [dbo].[Schools]    Script Date: 3/30/2021 08:45:43 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[Schools](
[id][int] NOT NULL,
[name] [nvarchar](50) NOT NULL,
[address] [nvarchar](50) NOT NULL,
[manager] [nvarchar](50) NOT NULL,
[managerPhone] [nvarchar](50) NOT NULL,
[schoolPhone] [nvarchar](50) NOT NULL,
[NumberOfMember] [int] NULL,
CONSTRAINT[PK_المدارس] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY]
GO
ALTER TABLE[dbo].[Members]  WITH CHECK ADD CONSTRAINT[FK_Members_Schools] FOREIGN KEY([SchoolId])
REFERENCES[dbo].[Schools]([id])
GO
ALTER");
            #endregion
            cmd.Connection = new SqlConnection(connectionstring);
            cmd.ExecuteNonQuery();
        }
        public DataTable GetSchools()
        {
            string sql = "SELECT * FROM Schools";
            List<DataAccess.School> schools = new List<DataAccess.School>();
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                schools = connection.Query<DataAccess.School>(sql).ToList();
                schools.ForEach(item =>
                {
                    item.NumberOfMembers = connection.QueryFirst<int>("SELECT COUNT(SchoolId) FROM [Members] WHERE SchoolId=@Id", new { item.Id });
                });
            }

            return ToDataTable(schools);
        }
        private bool ValidControl()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ادخل رقم المدرسة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!CheckDB())
            {
                GenerteDB();
            }
            DataTable table = GetSchools();
            Filldgv(table, dgv);
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
                Filldgv(GetSchools(), dgv);
                FrmMembers frm = new FrmMembers();
                Filldgv(ToDataTable(frm.LoadFrmMembers()), frm.dgv);
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
                    Filldgv(GetSchools(), dgv);
                    FrmMembers frm = new FrmMembers();
                    Filldgv(ToDataTable(frm.LoadFrmMembers()), frm.dgv);
                    btnReset.PerformClick();
                    MessageBox.Show("تم إجاء التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Filldgv(GetSchools(), dgv);
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
                Filldgv(dt, dgv);
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
            if (MessageBox.Show("هل تريد حذف هذا السجل", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                string DeleteCommand = "DELETE FROM [Schools] WHERE id = @id";
                SqlCommand cmd = new SqlCommand(DeleteCommand, connection);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                Filldgv(GetSchools(), dgv);
                FrmMembers frm = new FrmMembers();
                Filldgv(ToDataTable(frm.LoadFrmMembers()), frm.dgv);
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
            DataTable table = new DataTable();
            table = GetFromDataGridView(dgv);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "مصنف اكسيل|*.xlsx", InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add(table, $"المدارس");
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("تمّ تصدير البيانات إلى جدول اكسيل", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
