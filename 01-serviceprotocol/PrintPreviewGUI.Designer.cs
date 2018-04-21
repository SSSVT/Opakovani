namespace ServiceProtocol
{
    partial class PrintPreviewGUI
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
            this.pbx_main = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_main
            // 
            this.pbx_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_main.BackColor = System.Drawing.Color.White;
            this.pbx_main.Location = new System.Drawing.Point(12, 12);
            this.pbx_main.Name = "pbx_main";
            this.pbx_main.Size = new System.Drawing.Size(600, 538);
            this.pbx_main.TabIndex = 0;
            this.pbx_main.TabStop = false;
            this.pbx_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_main_Paint);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(537, 556);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Zavřít";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PrintPreviewGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 591);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pbx_main);
            this.MinimumSize = new System.Drawing.Size(640, 630);
            this.Name = "PrintPreviewGUI";
            this.Text = "Náhled tisku";
            this.Resize += new System.EventHandler(this.PrintPreviewGUI_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_main;
        private System.Windows.Forms.Button btn_close;
    }
}