using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinPrint dial = new WinPrint();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinPrint dial = new WinPrint();
            dial.ShowDialog();
        }
    }
}
