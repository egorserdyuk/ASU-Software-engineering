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
    public partial class Winprint2 : Form
    {
        public Winprint2()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Rows = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Columns = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Zoom = (double)numericUpDown3.Value / 100;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            printPreviewControl1.UseAntiAlias = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void Winprint2_Load(object sender, EventArgs e)
        {

        }
    }
}
