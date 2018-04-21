using ServiceProtocol.Models;
using System;
using System.Windows.Forms;

namespace ServiceProtocol
{
    public partial class GeneralGUI : Form
    {
        #region Constructors
        protected GeneralGUI()
        {
            InitializeComponent();
        }        
        public GeneralGUI(ServiceProtocolModel model) : this()
        {
            this.ServiceProtocolModel = model;
            this.tbx_protocol_no.Text = model.ProtocolNumber;
            this.dtp_measurement_date.Value = model.MeasurementDate;
        }
        #endregion
        #region Events
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                this.ServiceProtocolModel.ProtocolNumber = this.tbx_protocol_no.Text;
                this.ServiceProtocolModel.MeasurementDate = this.dtp_measurement_date.Value;
                this.DialogResult = DialogResult.OK;
            }            
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void tbx_protocol_no_TextChanged(object sender, EventArgs e)
        {
            this.IsProtocolNoValid();
        }
        #endregion

        #region Properties
        public ServiceProtocolModel ServiceProtocolModel { get; protected set; }
        #endregion
        #region Validation
        protected bool IsValid()
        {
            bool isValid = true;

            isValid &= this.IsProtocolNoValid();

            return isValid;
        }
        protected bool IsProtocolNoValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_protocol_no.Text))
            {
                this.errorProvider1.SetError(this.tbx_protocol_no, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_protocol_no, null);
            }

            return isValid;
        }
        #endregion
    }
}
