namespace CoordinateSystem
{
    partial class ViewerGUI
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
            this.pbx_coosystem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_coosystem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_coosystem
            // 
            this.pbx_coosystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_coosystem.BackColor = System.Drawing.Color.White;
            this.pbx_coosystem.Location = new System.Drawing.Point(12, 12);
            this.pbx_coosystem.Name = "pbx_coosystem";
            this.pbx_coosystem.Size = new System.Drawing.Size(560, 337);
            this.pbx_coosystem.TabIndex = 0;
            this.pbx_coosystem.TabStop = false;
            this.pbx_coosystem.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_coosystem_Paint);
            // 
            // ViewerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pbx_coosystem);
            this.Name = "ViewerGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coordinate System";
            this.Resize += new System.EventHandler(this.ViewerGUI_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_coosystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_coosystem;
    }
}