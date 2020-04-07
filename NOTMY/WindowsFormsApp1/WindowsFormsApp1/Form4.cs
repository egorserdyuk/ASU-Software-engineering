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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 dial = new Form5();
            dial.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 dial = new Form6();
            dial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nForm dial = new nForm();
            dial.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParentForm dial = new ParentForm();
            dial.ShowDialog();
        }
    }
}
