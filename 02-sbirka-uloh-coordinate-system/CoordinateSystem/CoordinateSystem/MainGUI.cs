using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinateSystem
{
    public partial class MainGUI : Form
    {
        protected BindingList<PointF> _Points { get; set; } = new BindingList<PointF>();

        public MainGUI()
        {
            InitializeComponent();
            this.dgv_points.DataSource = this._Points;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PointGUI pointGUI = new PointGUI();
            if (pointGUI.ShowDialog() == DialogResult.OK)
            {
                this._Points.Add(pointGUI.PointF);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.dgv_points.CurrentRow != null)
            {
                PointGUI pointGUI = new PointGUI(this._Points[this.dgv_points.CurrentRow.Index]);
                if (pointGUI.ShowDialog() == DialogResult.OK)
                {
                    this._Points[this.dgv_points.CurrentRow.Index] = pointGUI.PointF;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.dgv_points.CurrentRow != null)
                this._Points.RemoveAt(this.dgv_points.CurrentRow.Index);
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ViewerGUI viewer = new ViewerGUI(this._Points);
            viewer.ShowDialog();
        }
    }
}
