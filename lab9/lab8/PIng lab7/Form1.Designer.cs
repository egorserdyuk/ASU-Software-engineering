namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.userControlTimer21 = new Lab8.UserControlTimer2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.helpProvider1.SetHelpString(this.menuStrip1, "jhkjhk");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dialogToolStripMenuItem,
            this.reverseToolStripMenuItem,
            this.winPrintToolStripMenuItem,
            this.winBackgroundToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.helpProvider1.SetShowHelp(this.menuStrip1, true);
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoToolTip = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem1.Text = "PDF Reader";
            this.toolStripMenuItem1.ToolTipText = "Restrictions removed - whatever you need to open a lot of PDF files";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dialogToolStripMenuItem
            // 
            this.dialogToolStripMenuItem.Name = "dialogToolStripMenuItem";
            this.dialogToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.dialogToolStripMenuItem.Text = "Anim";
            this.dialogToolStripMenuItem.ToolTipText = "Animation of windows";
            this.dialogToolStripMenuItem.Click += new System.EventHandler(this.dialogToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reverseToolStripMenuItem.Text = "Reverse";
            this.reverseToolStripMenuItem.ToolTipText = "Reverse and Upper Case string calculator";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // winPrintToolStripMenuItem
            // 
            this.winPrintToolStripMenuItem.Name = "winPrintToolStripMenuItem";
            this.winPrintToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.winPrintToolStripMenuItem.Text = "Print";
            this.winPrintToolStripMenuItem.ToolTipText = "Print txt file";
            this.winPrintToolStripMenuItem.Click += new System.EventHandler(this.winPrintToolStripMenuItem_Click);
            // 
            // winBackgroundToolStripMenuItem
            // 
            this.winBackgroundToolStripMenuItem.Name = "winBackgroundToolStripMenuItem";
            this.winBackgroundToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.winBackgroundToolStripMenuItem.Text = "Background";
            this.winBackgroundToolStripMenuItem.ToolTipText = "Async application";
            this.winBackgroundToolStripMenuItem.Click += new System.EventHandler(this.winBackgroundToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.helpProvider1.SetShowHelp(this.contextMenuStrip1, true);
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.BackColor = System.Drawing.Color.Transparent;
            this.userControlTimer21.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlTimer21.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlTimer21.Location = new System.Drawing.Point(134, 31);
            this.userControlTimer21.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.userControlTimer21.Name = "userControlTimer21";
            this.helpProvider1.SetShowHelp(this.userControlTimer21, true);
            this.userControlTimer21.Size = new System.Drawing.Size(150, 51);
            this.userControlTimer21.TabIndex = 2;
            this.toolTip1.SetToolTip(this.userControlTimer21, "Current time");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 81);
            this.Controls.Add(this.userControlTimer21);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(50, 80);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lab 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dialogToolStripMenuItem;
        private UserControlTimer2 userControlTimer21;
        private System.Windows.Forms.ToolStripMenuItem winPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winBackgroundToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

