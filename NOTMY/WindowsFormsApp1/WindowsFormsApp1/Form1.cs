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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 dial = new Form4();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 dial = new Form8();
            dial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 dial = new Form9();
            dial.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 dial = new Form10();
            dial.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 dial = new Form11();
            dial.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 dial = new Form12();
            dial.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 dial = new Form13();
            dial.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 dial = new Form14();
            dial.ShowDialog();
        }
    }
}
