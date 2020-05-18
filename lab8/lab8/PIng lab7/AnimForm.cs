using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Lab8
{
    public partial class AnimForm : Form
    {
        public AnimForm()
        {
            InitializeComponent();
        }

        private void AnimForm_Load(object sender, EventArgs e)
        {
            Form1.flag = true;
        }

        private void AnimForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.flag = false;
            WinAPIClass.AnimateWindow(this, 1000, WinAPIClass.AnimatedWindowFlags.AW_BLEND | WinAPIClass.AnimatedWindowFlags.AW_HIDE);
        }

        private void btn_AW_BLEND_Click(object sender, EventArgs e)
        {
            Hide();
            WinAPIClass.AnimateWindow(this, 1000, WinAPIClass.AnimatedWindowFlags.AW_BLEND);
        }

        private void btn_HOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            Hide();
            WinAPIClass.AnimateWindow(this, 1000,WinAPIClass.AnimatedWindowFlags.AW_HOR_POSITIVE);
        }

        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            Hide();
            WinAPIClass.AnimateWindow(this, 1000, WinAPIClass.AnimatedWindowFlags.AW_CENTER);
        }
    }

    public class WinAPIClass
    {
        #region Анимация окна
        /// <summary>
        /// Тип анимации окна. Перечисление возвращает тип инт
        /// после приведения. Каждому элементу присвоено
        /// новое значение типа int/
        /// </summary>
        [Flags]
        public enum AnimatedWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 9,
            AW_CENTER = 16,
            AW_HIDE = 65536,
            AW_ACTIVATE = 121072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288
        };

        /// <summary>
        /// Анимация окна
        /// </summary>
        /// <param name="hwnd">Окно</param>
        /// <param name="dwTime">Время.</param>
        /// <param name="dwFlags">Тип анимации. Если в
        /// неуправляемом коде используется перечисление, то его
        /// нужно конвертивовать в тип данных int.
        /// </param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        /// <summary>
        /// Анимация окна
        /// </summary>
        /// <param name="ctrl">Окно.</param>
        /// <param name="Time">Время.</param>
        /// <param name="Flags">Флаги.</param>
        /// <returns></returns>
        public static bool AnimateWindow(Control ctrl, int dwTime, AnimatedWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion
    };
    
}
