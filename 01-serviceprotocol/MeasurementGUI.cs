using ServiceProtocol.Models;
using System;
using System.Windows.Forms;

namespace ServiceProtocol
{
    public partial class MeasurementGUI : Form
    {
        public MeasurementGUI()
        {
            InitializeComponent();
        }
        public MeasurementGUI(MeasurementModel model) : this()
        {
            this.MeasurementModel = model;
            this.tbx_parameter.Text = model.Parameter;
            this.tbx_measured_value.Text = model.MeasuredValue.ToString();
            this.tbx_unit.Text = model.Unit;
            this.cbx_is_valid.Checked = (model.IsValid == "Ano") ? true : false;
        }

        public MeasurementModel MeasurementModel { get; protected set; } = new MeasurementModel();

        #region Events
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                this.MeasurementModel.Parameter = this.tbx_parameter.Text;
                this.MeasurementModel.MeasuredValue = Convert.ToDouble(this.tbx_measured_value.Text.Replace(',', '.'));
                this.MeasurementModel.Unit = this.tbx_unit.Text;
                this.MeasurementModel.IsValid = (this.cbx_is_valid.Checked) ? "Ano" : "Ne";
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void tbx_parameter_TextChanged(object sender, EventArgs e)
        {
            this.IsParameterValid();
        }
        private void tbx_measured_value_TextChanged(object sender, EventArgs e)
        {
            this.IsMeasuredValueValid();
        }
        private void tbx_unit_TextChanged(object sender, EventArgs e)
        {
            this.IsUnitValid();
        }
        #endregion

        #region Validation
        protected bool IsValid()
        {
            bool isValid = true;

            isValid &= this.IsParameterValid();
            isValid &= this.IsMeasuredValueValid();
            isValid &= this.IsUnitValid();

            return isValid;
        }

        protected bool IsParameterValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_parameter.Text))
            {
                this.errorProvider1.SetError(this.tbx_parameter, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_parameter, null);
            }

            return isValid;
        }
        protected bool IsMeasuredValueValid()
        {
            bool isValid = true;

            try
            {
                this.errorProvider1.SetError(this.tbx_measured_value, null);
                double d = Convert.ToDouble(this.tbx_measured_value.Text);
            }
            catch (Exception ex)
            {
                this.errorProvider1.SetError(this.tbx_measured_value, "Pole nesmí být prázdné");
                isValid = false;
            }

            return isValid;
        }
        protected bool IsUnitValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_unit.Text))
            {
                this.errorProvider1.SetError(this.tbx_unit, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_unit, null);
            }

            return isValid;
        }
        #endregion
    }
}
