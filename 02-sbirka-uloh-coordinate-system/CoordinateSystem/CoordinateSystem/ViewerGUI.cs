using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoordinateSystem
{
    public partial class ViewerGUI : Form
    {
        public ViewerGUI(BindingList<PointF> points)
        {
            InitializeComponent();
            this._Points = points;
        }

        protected BindingList<PointF> _Points { get; set; }

        private void pbx_coosystem_Paint(object sender, PaintEventArgs e)
        {
            float centerX = e.Graphics.ClipBounds.Width / 2F;
            float centerY = e.Graphics.ClipBounds.Height / 2F;

            e.Graphics.TranslateTransform(centerX, centerY);

            e.Graphics.DrawLine(Pens.Black, 0, -1F * e.Graphics.ClipBounds.Height / 2F, 0, e.Graphics.ClipBounds.Height);
            e.Graphics.DrawLine(Pens.Black, -1F * e.Graphics.ClipBounds.Width / 2F, 0, e.Graphics.ClipBounds.Width / 2F, 0);

            Font text = new Font("Arial", 8F);

            for (float i = 1; i < e.Graphics.ClipBounds.Width / 2F; i++)
            {
                if (i % 10 == 0)
                {
                    string minusValue = $"-{i}";
                    SizeF minusSizeF = e.Graphics.MeasureString(minusValue, text);
                    string plusValue = $"{i}";
                    SizeF plusSizeF = e.Graphics.MeasureString(plusValue, text);
                    //X
                    e.Graphics.DrawLine(Pens.Black, -10F * i, -8F, -10F * i, 8F); //-
                    e.Graphics.DrawString(minusValue, text, Brushes.Black, -10F * i - minusSizeF.Width / 2F, 16F);

                    e.Graphics.DrawLine(Pens.Black, 10F * i, -8F, 10F * i, 8F); //+
                    e.Graphics.DrawString(plusValue, text, Brushes.Black, 10F * i - plusSizeF.Width / 2F, 16F);

                    //Y
                    e.Graphics.DrawLine(Pens.Black, -8F, 10F * i, 8F, 10F * i); //-
                    e.Graphics.DrawString(minusValue, text, Brushes.Black, 16F, 10F * i - minusSizeF.Height / 2F);
                    e.Graphics.DrawLine(Pens.Black, -8F, -10F * i, 8F, -10F * i); //+
                    e.Graphics.DrawString(plusValue, text, Brushes.Black, 16F, -10F * i - plusSizeF.Height / 2F);

                }
                else
                {
                    e.Graphics.DrawLine(Pens.Black, -10F * i, -4F, -10F * i, 4F); //-X
                    e.Graphics.DrawLine(Pens.Black, 10F * i, -4F, 10F * i, 4F); //+X

                    e.Graphics.DrawLine(Pens.Black, 4F, -10F * i, -4F, -10F * i); //+Y
                    e.Graphics.DrawLine(Pens.Black, 4F, 10F * i, -4F, 10F * i); //-Y
                }
            }

            foreach (PointF item in this._Points)
            {
                e.Graphics.DrawEllipse(Pens.Black, item.X * 10F - 2F, -1F * item.Y * 10F - 2F, 4F, 4F);
            }
        }

        private void ViewerGUI_Resize(object sender, EventArgs e)
        {
            this.pbx_coosystem.Refresh();
        }
    }
}
