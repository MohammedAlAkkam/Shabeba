using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shabeba
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers1.BringToFront();
            btnMembers.BackColor = Color.DimGray;
            btnSchools.BackColor = Color.DarkGray;
        }

        private void btnSchools_Click(object sender, EventArgs e)
        {
            school1.BringToFront(); 
            btnMembers.BackColor = Color.DarkGray;
            btnSchools.BackColor = Color.DimGray;
        }

        private void frmMembers1_Load(object sender, EventArgs e)
        {
            btnMembers.BackColor = Color.DimGray;

        }
    }
}
