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
    public partial class WinLinkLabel : Form
    {
        public WinLinkLabel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            WinLinkLabel2 aForm = new WinLinkLabel2();
            aResult = aForm.ShowDialog();
            if(aResult==System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Your name is " + aForm.textBox1.Text + " " + aForm.textBox2.Text);
                MessageBox.Show("Your phone number is " + aForm.maskedTextBox1.Text);
            }
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.asu.ru");
            linkLabel2.LinkVisited = true;
        }
    }
}
