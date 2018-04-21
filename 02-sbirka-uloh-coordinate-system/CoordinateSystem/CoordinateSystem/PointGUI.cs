using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoordinateSystem
{
    public partial class PointGUI : Form
    {
        public PointGUI()
        {
            InitializeComponent();
        }
        public PointGUI(PointF pointF) : this()
        {
            this.PointF = pointF;
            this.tbx_X.Text = this.PointF.X.ToString();
            this.tbx_Y.Text = this.PointF.Y.ToString();
        }

        public PointF PointF { get; set; }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                this.PointF = new PointF(Convert.ToSingle(this.tbx_X.Text.Replace(',', '.')), Convert.ToSingle(this.tbx_Y.Text.Replace(',', '.')));
                this.DialogResult = DialogResult.OK;
            }            
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected bool IsValid()
        {
            bool isValid = true;
            isValid &= this.IsXCoordinateValid();
            isValid &= this.IsYCoordinateValid();
            return isValid;
        }
        protected bool IsXCoordinateValid()
        {
            try
            {
                float tmp = Convert.ToSingle(this.tbx_X.Text.Replace(',', '.'));
                this.errorProvider1.SetError(this.tbx_X, null);
                return true;
            }
            catch (Exception)
            {
                this.errorProvider1.SetError(this.tbx_X, "Invalid value");
                return false;
            }
        }
        protected bool IsYCoordinateValid()
        {
            try
            {
                float tmp = Convert.ToSingle(this.tbx_Y.Text.Replace(',', '.'));
                this.errorProvider1.SetError(this.tbx_Y, null);
                return true;
            }
            catch (Exception)
            {
                this.errorProvider1.SetError(this.tbx_Y, "Invalid value");
                return false;
            }
        }

        private void tbx_X_Leave(object sender, EventArgs e)
        {
            this.IsXCoordinateValid();
        }

        private void tbx_Y_Leave(object sender, EventArgs e)
        {
            this.IsYCoordinateValid();
        }
    }
}
