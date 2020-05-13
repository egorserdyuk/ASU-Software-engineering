using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sol1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] ch = textBox1.Text.ToCharArray();
            int parent = 0;
            int count = 0;
            for (int i = ch.Length - 1; i >= 0; --i)
            {
                int j = int.Parse(ch[i].ToString());
                if (count != 0 || j != 0)
                    parent += (int)Math.Pow(j * 2.0, count);
                count++;
            }
            if (radioButton1.Checked)
                textBox2.Text = Convert.ToString(parent, 8);
            else if (radioButton2.Checked)
                textBox2.Text = parent.ToString();
            else if (radioButton3.Checked)
                textBox2.Text = Convert.ToString(parent, 16);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '0')
                e.Handled = true;
        }
    }
}
