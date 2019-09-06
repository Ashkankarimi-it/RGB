namespace RGB
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
            this.redHScrollbar = new System.Windows.Forms.HScrollBar();
            this.blueHScrollbar = new System.Windows.Forms.HScrollBar();
            this.greenHScrolbar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // redHScrollbar
            // 
            this.redHScrollbar.Location = new System.Drawing.Point(9, 9);
            this.redHScrollbar.Maximum = 255;
            this.redHScrollbar.Name = "redHScrollbar";
            this.redHScrollbar.Size = new System.Drawing.Size(424, 28);
            this.redHScrollbar.TabIndex = 0;
            this.redHScrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollbar_Scroll);
            // 
            // blueHScrollbar
            // 
            this.blueHScrollbar.Location = new System.Drawing.Point(9, 98);
            this.blueHScrollbar.Maximum = 255;
            this.blueHScrollbar.Name = "blueHScrollbar";
            this.blueHScrollbar.Size = new System.Drawing.Size(424, 28);
            this.blueHScrollbar.TabIndex = 1;
            this.blueHScrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollbar_Scroll);
            // 
            // greenHScrolbar
            // 
            this.greenHScrolbar.Location = new System.Drawing.Point(9, 53);
            this.greenHScrolbar.Maximum = 255;
            this.greenHScrolbar.Name = "greenHScrolbar";
            this.greenHScrolbar.Size = new System.Drawing.Size(424, 28);
            this.greenHScrolbar.TabIndex = 2;
            this.greenHScrolbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollbar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 345);
            this.Controls.Add(this.greenHScrolbar);
            this.Controls.Add(this.blueHScrollbar);
            this.Controls.Add(this.redHScrollbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar redHScrollbar;
        private System.Windows.Forms.HScrollBar blueHScrollbar;
        private System.Windows.Forms.HScrollBar greenHScrolbar;
    }
}

