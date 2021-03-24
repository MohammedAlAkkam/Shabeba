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

namespace Shabeba
{
    public partial class School : Form
    {
        public School()
        {
            InitializeComponent();
        }

        private void School_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory());
           /* PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile(@"C:\Users\SAEED\Source\Repos\Shabeba\WindowsFormsApplication30\font.ttf");
            foreach (Control control in this.Controls)
            {
                control.Font = new Font(privateFont.Families[0],16,FontStyle.Regular);
            }*/
        }
    }
}
