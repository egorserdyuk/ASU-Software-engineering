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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 dial = new Form7();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestList dial = new TestList();
            dial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParentForm dial = new ParentForm();
            dial.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParentForm dial = new ParentForm();
            dial.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WinContainer dial = new WinContainer();
            dial.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WinLinkLabel dial = new WinLinkLabel();
            dial.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WinLinkLabel dial = new WinLinkLabel();
            dial.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrationForm dial = new RegistrationForm();
            dial.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrationForm dial = new RegistrationForm();
            dial.ShowDialog();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
