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
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("font.ttf");
        }
    }
}
