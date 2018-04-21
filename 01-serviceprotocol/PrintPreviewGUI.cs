using ServiceProtocol.Models;
using System;
using System.Windows.Forms;

namespace ServiceProtocol
{
    public partial class PrintPreviewGUI : Form
    {
        protected PrintPreviewGUI()
        {
            InitializeComponent();
        }
        public PrintPreviewGUI(ServiceProtocolModel model) : this()
        {
            this._ServiceProtocolModel = model;
        }

        protected ServiceProtocolModel _ServiceProtocolModel { get; set; }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbx_main_Paint(object sender, PaintEventArgs e)
        {
            this._ServiceProtocolModel.Draw(e.Graphics);
        }

        private void PrintPreviewGUI_Resize(object sender, EventArgs e)
        {
            this.pbx_main.Refresh();
        }
    }
}
