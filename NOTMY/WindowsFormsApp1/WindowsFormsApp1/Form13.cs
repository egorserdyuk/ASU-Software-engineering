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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinBackgroundWorker dial = new WinBackgroundWorker();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinAsynchDelegate dial = new WinAsynchDelegate();
            dial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WinAsynchMetod dial = new WinAsynchMetod();
            dial.ShowDialog();
        }
    }
}
