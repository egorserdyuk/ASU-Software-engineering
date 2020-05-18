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
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            Form1.flag = true;
        }

        private void PrintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.flag = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            float MyLines = 0;
            float YPosition = 0;
            int Counter = 0;
            string CurrentLine;
            MyLines = e.MarginBounds.Height / this.Font.GetHeight(e.Graphics);
            try
            {
                while (Counter < MyLines && ArrayCounter <= strings.Length - 1)
                {
                    CurrentLine = strings[ArrayCounter];
                    YPosition = TopMargin + Counter * this.Font.GetHeight(e.Graphics);
                    e.Graphics.DrawString(CurrentLine, this.Font, Brushes.Black, LeftMargin, YPosition, new StringFormat());
                    Counter++;
                    ArrayCounter++;
                }
            }
            catch
            {
                Close();
                MessageBox.Show(Convert.ToString("Вы не выбрали файл. Теперь вас ждет ошибка!"));
                
            }
            if (!(ArrayCounter >= strings.GetLength(0) - 1))
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintPreviewForm aForm = new PrintPreviewForm();
            System.Windows.Forms.DialogResult aResult;
            aForm.printPreviewControl1.Document = printDocument1;
            aResult = aForm.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
                printDocument1.Print();
        }

        string s;
        string[] strings;
        int ArrayCounter = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult aResult;
            aResult = openFileDialog1.ShowDialog();
            if(aResult == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader aReader = new System.IO.StreamReader(openFileDialog1.FileName);
                s = aReader.ReadToEnd();
                aReader.Close();
                strings = s.Split('\n');
            }
        }
    }
}
