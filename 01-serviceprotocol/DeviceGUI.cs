using ServiceProtocol.Models;
using System;
using System.Windows.Forms;

namespace ServiceProtocol
{
    public partial class DeviceGUI : Form
    {
        protected DeviceGUI()
        {
            InitializeComponent();
        }
        public DeviceGUI(DeviceModel model) : this()
        {
            this.DeviceModel = model;
            this.tbx_manufacturer.Text = model.Manufacturer;
            this.tbx_model.Text = model.Model;
            this.tbx_serial_number.Text = model.SerialNumber;
        }

        public DeviceModel DeviceModel { get; protected set; }

        #region Events
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                this.DeviceModel.Manufacturer = this.tbx_manufacturer.Text;
                this.DeviceModel.Model = this.tbx_model.Text;
                this.DeviceModel.SerialNumber = this.tbx_serial_number.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void tbx_manufacturer_TextChanged(object sender, EventArgs e)
        {
            this.IsManufacturerValid();
        }
        private void tbx_model_TextChanged(object sender, EventArgs e)
        {
            this.IsModelValid();
        }
        private void tbx_serial_number_TextChanged(object sender, EventArgs e)
        {
            this.IsSerialNumberValid();
        }
        #endregion

        #region Validation
        protected bool IsValid()
        {
            bool isValid = true;

            isValid &= this.IsManufacturerValid();
            isValid &= this.IsModelValid();
            isValid &= this.IsSerialNumberValid();

            return isValid;
        }

        protected bool IsManufacturerValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_manufacturer.Text))
            {
                this.errorProvider1.SetError(this.tbx_manufacturer, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_manufacturer, null);
            }

            return isValid;
        }
        protected bool IsModelValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_model.Text))
            {
                this.errorProvider1.SetError(this.tbx_model, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_model, null);
            }

            return isValid;
        }
        protected bool IsSerialNumberValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_serial_number.Text))
            {
                this.errorProvider1.SetError(this.tbx_serial_number, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_serial_number, null);
            }

            return isValid;
        }
        #endregion
    }
}
