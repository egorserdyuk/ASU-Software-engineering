using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class WinLanguage : Form
    {
        public WinLanguage()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture =
            Thread.CurrentThread.CurrentCulture;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WinLanguage_Load(object sender, EventArgs e)
        {

        }
    }
}
