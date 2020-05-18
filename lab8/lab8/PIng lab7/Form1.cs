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
    public partial class Form1 : Form
    {
        public static bool flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag = false;
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dial = new Form2();
            if (flag == false)
            {
                dial.Show();
            }
            else if (flag == true)
            {
                MessageBox.Show(Convert.ToString("The form is already open"));
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by Egor Serdyuk\nThe ninth variant\n474b");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimForm dial = new AnimForm();
            if (flag == false)
            {
                dial.Show();
            }
            else if (flag == true)
            {
                MessageBox.Show(Convert.ToString("The form is already open"));
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PDFReaderForm dial = new PDFReaderForm();
            if (flag == false)
            {
                dial.Show();
            }
            else if (flag == true)
            {
                MessageBox.Show(Convert.ToString("The form is already open"));
            }
        }
        private void winPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm dial = new PrintForm();
            if (flag == false)
            {
                dial.Show();
            }
            else if (flag == true)
            {
                MessageBox.Show(Convert.ToString("The form is already open"));
            }
        }

        private void winBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinBackGroundForm dial = new WinBackGroundForm();
            if (flag == false)
            {
                dial.Show();
            }
            else if (flag == true)
            {
                MessageBox.Show(Convert.ToString("The form is already open"));
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
