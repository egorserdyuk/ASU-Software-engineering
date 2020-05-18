namespace Lab8
{
    partial class AnimForm
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
            this.btn_AW_BLEND = new System.Windows.Forms.Button();
            this.btn_HOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnCenter_AW_SLIDE = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btn_AW_BLEND
            // 
            this.btn_AW_BLEND.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.btn_AW_BLEND, "Window is showing up from nowhere like a ghost");
            this.btn_AW_BLEND.Location = new System.Drawing.Point(12, 13);
            this.btn_AW_BLEND.Name = "btn_AW_BLEND";
            this.helpProvider1.SetShowHelp(this.btn_AW_BLEND, true);
            this.btn_AW_BLEND.Size = new System.Drawing.Size(149, 46);
            this.btn_AW_BLEND.TabIndex = 0;
            this.btn_AW_BLEND.Text = "Blend";
            this.btn_AW_BLEND.UseVisualStyleBackColor = true;
            this.btn_AW_BLEND.Click += new System.EventHandler(this.btn_AW_BLEND_Click);
            // 
            // btn_HOR_AW_SLIDE
            // 
            this.btn_HOR_AW_SLIDE.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.btn_HOR_AW_SLIDE, "");
            this.btn_HOR_AW_SLIDE.Location = new System.Drawing.Point(12, 80);
            this.btn_HOR_AW_SLIDE.Name = "btn_HOR_AW_SLIDE";
            this.helpProvider1.SetShowHelp(this.btn_HOR_AW_SLIDE, true);
            this.btn_HOR_AW_SLIDE.Size = new System.Drawing.Size(149, 51);
            this.btn_HOR_AW_SLIDE.TabIndex = 1;
            this.btn_HOR_AW_SLIDE.Text = "Horizontal Positive";
            this.btn_HOR_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btn_HOR_AW_SLIDE.Click += new System.EventHandler(this.btn_HOR_AW_SLIDE_Click);
            // 
            // btnCenter_AW_SLIDE
            // 
            this.btnCenter_AW_SLIDE.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.btnCenter_AW_SLIDE, "");
            this.btnCenter_AW_SLIDE.Location = new System.Drawing.Point(12, 152);
            this.btnCenter_AW_SLIDE.Name = "btnCenter_AW_SLIDE";
            this.helpProvider1.SetShowHelp(this.btnCenter_AW_SLIDE, true);
            this.btnCenter_AW_SLIDE.Size = new System.Drawing.Size(149, 51);
            this.btnCenter_AW_SLIDE.TabIndex = 2;
            this.btnCenter_AW_SLIDE.Text = "Center";
            this.btnCenter_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btnCenter_AW_SLIDE.Click += new System.EventHandler(this.btnCenter_AW_SLIDE_Click);
            // 
            // AnimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 220);
            this.Controls.Add(this.btnCenter_AW_SLIDE);
            this.Controls.Add(this.btn_HOR_AW_SLIDE);
            this.Controls.Add(this.btn_AW_BLEND);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(50, 135);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Animation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimForm_FormClosing);
            this.Load += new System.EventHandler(this.AnimForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AW_BLEND;
        private System.Windows.Forms.Button btn_HOR_AW_SLIDE;
        private System.Windows.Forms.Button btnCenter_AW_SLIDE;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}