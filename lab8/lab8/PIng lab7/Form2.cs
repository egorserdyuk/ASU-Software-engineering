using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1.flag = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.flag = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (checkBox1.Checked == true)
                textBox1.Text = textBox1.Text.ToUpper();
            if (checkBox2.Checked == true)
            {
                char[] ch = textBox1.Text.ToCharArray();
                Array.Reverse(ch);
                textBox1.Text = new string(ch);
            }


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Симаков Артем\nГруппа 474б");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Form1.ActiveForm.Close();
            
        }


    }
}
