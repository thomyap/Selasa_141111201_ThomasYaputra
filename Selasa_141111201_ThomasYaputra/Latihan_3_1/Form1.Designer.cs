namespace Latihan_3_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsFont = new System.Windows.Forms.ToolStripComboBox();
            this.tsColor = new System.Windows.Forms.ToolStripComboBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBold,
            this.tsItalic,
            this.tsUnderline,
            this.tsFontSize,
            this.tsFont,
            this.tsColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBold
            // 
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = ((System.Drawing.Image)(resources.GetObject("tsBold.Image")));
            this.tsBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(23, 24);
            this.tsBold.Text = "Bold";
            this.tsBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // tsItalic
            // 
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsItalic.Image")));
            this.tsItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(23, 24);
            this.tsItalic.Text = "Italic";
            this.tsItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsUnderline
            // 
            this.tsUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsUnderline.Image")));
            this.tsUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnderline.Name = "tsUnderline";
            this.tsUnderline.Size = new System.Drawing.Size(23, 24);
            this.tsUnderline.Text = "Underline";
            this.tsUnderline.Click += new System.EventHandler(this.tsUnderline_Click);
            // 
            // tsFontSize
            // 
            this.tsFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsFontSize.Name = "tsFontSize";
            this.tsFontSize.Size = new System.Drawing.Size(121, 27);
            this.tsFontSize.SelectedIndexChanged += new System.EventHandler(this.tsFontSize_SelectedIndexChanged);
            // 
            // tsFont
            // 
            this.tsFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsFont.Name = "tsFont";
            this.tsFont.Size = new System.Drawing.Size(121, 27);
            this.tsFont.SelectedIndexChanged += new System.EventHandler(this.tsFont_SelectedIndexChanged);
            // 
            // tsColor
            // 
            this.tsColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsColor.Name = "tsColor";
            this.tsColor.Size = new System.Drawing.Size(121, 23);
            this.tsColor.SelectedIndexChanged += new System.EventHandler(this.tsColor_SelectedIndexChanged);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(-1, 21);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(444, 270);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            this.rtb.SelectionChanged += new System.EventHandler(this.rtb_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 304);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tsFontSize;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderline;
        private System.Windows.Forms.ToolStripComboBox tsFont;
        private System.Windows.Forms.ToolStripComboBox tsColor;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

