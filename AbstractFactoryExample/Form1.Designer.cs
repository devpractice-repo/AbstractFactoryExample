namespace AbstractFactoryExample
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
            this.tsToolbox = new System.Windows.Forms.ToolStrip();
            this.cbFigType = new System.Windows.Forms.ToolStripComboBox();
            this.tbBuild = new System.Windows.Forms.ToolStripButton();
            this.tbClear = new System.Windows.Forms.ToolStripButton();
            this.tsToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsToolbox
            // 
            this.tsToolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbFigType,
            this.tbBuild,
            this.tbClear});
            this.tsToolbox.Location = new System.Drawing.Point(0, 0);
            this.tsToolbox.Name = "tsToolbox";
            this.tsToolbox.Size = new System.Drawing.Size(403, 25);
            this.tsToolbox.TabIndex = 0;
            this.tsToolbox.Text = "toolStrip1";
            // 
            // cbFigType
            // 
            this.cbFigType.Items.AddRange(new object[] {
            "Red",
            "Green"});
            this.cbFigType.Name = "cbFigType";
            this.cbFigType.Size = new System.Drawing.Size(121, 25);
            // 
            // tbBuild
            // 
            this.tbBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbBuild.Image = ((System.Drawing.Image)(resources.GetObject("tbBuild.Image")));
            this.tbBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBuild.Name = "tbBuild";
            this.tbBuild.Size = new System.Drawing.Size(33, 22);
            this.tbBuild.Text = "Build";
            this.tbBuild.Click += new System.EventHandler(this.tbBuild_Click);
            // 
            // tbClear
            // 
            this.tbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbClear.Image = ((System.Drawing.Image)(resources.GetObject("tbClear.Image")));
            this.tbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(36, 22);
            this.tbClear.Text = "Clear";
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 245);
            this.Controls.Add(this.tsToolbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "AbstarctFactoryExample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsToolbox.ResumeLayout(false);
            this.tsToolbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsToolbox;
        private System.Windows.Forms.ToolStripComboBox cbFigType;
        private System.Windows.Forms.ToolStripButton tbBuild;
        private System.Windows.Forms.ToolStripButton tbClear;
    }
}

