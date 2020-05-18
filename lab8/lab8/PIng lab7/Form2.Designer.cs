namespace Lab8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.helpProvider1.SetHelpKeyword(this.textBox1, resources.GetString("textBox1.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.textBox1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("textBox1.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.textBox1, resources.GetString("textBox1.HelpString"));
            this.textBox1.Name = "textBox1";
            this.helpProvider1.SetShowHelp(this.textBox1, ((bool)(resources.GetObject("textBox1.ShowHelp"))));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.helpProvider1.SetHelpKeyword(this.label1, resources.GetString("label1.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.label1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("label1.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.label1, resources.GetString("label1.HelpString"));
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, ((bool)(resources.GetObject("label1.ShowHelp"))));
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.helpProvider1.SetHelpKeyword(this.checkBox1, resources.GetString("checkBox1.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.checkBox1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("checkBox1.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.checkBox1, resources.GetString("checkBox1.HelpString"));
            this.checkBox1.Name = "checkBox1";
            this.helpProvider1.SetShowHelp(this.checkBox1, ((bool)(resources.GetObject("checkBox1.ShowHelp"))));
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.helpProvider1.SetHelpKeyword(this.checkBox2, resources.GetString("checkBox2.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.checkBox2, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("checkBox2.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.checkBox2, resources.GetString("checkBox2.HelpString"));
            this.checkBox2.Name = "checkBox2";
            this.helpProvider1.SetShowHelp(this.checkBox2, ((bool)(resources.GetObject("checkBox2.ShowHelp"))));
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.helpProvider1.SetHelpKeyword(this.button1, resources.GetString("button1.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.button1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button1.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.button1, resources.GetString("button1.HelpString"));
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, ((bool)(resources.GetObject("button1.ShowHelp"))));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            resources.ApplyResources(this.helpProvider1, "helpProvider1");
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}