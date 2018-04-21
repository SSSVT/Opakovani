using ServiceProtocol.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServiceProtocol
{
    public partial class CustomerGUI : Form
    {
        #region Constructors
        protected CustomerGUI()
        {
            InitializeComponent();
        }
        public CustomerGUI(CustomerModel model) : this()
        {
            this.CustomerModel = model;
            this.tbx_name.Text = model.Name;
            this.tbx_address_text.Text = model.Address;
            this.tbx_postal_code.Text = model.PostalCode;
            this.tbx_ic.Text = model.IC;
        }
        #endregion

        #region Events
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                this.CustomerModel.Name = this.tbx_name.Text;
                this.CustomerModel.Address = this.tbx_address_text.Text;
                this.CustomerModel.PostalCode = this.tbx_postal_code.Text;
                this.CustomerModel.IC = this.tbx_ic.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbx_name_TextChanged(object sender, EventArgs e)
        {
            this.IsNameValid();
        }
        private void tbx_address_text_TextChanged(object sender, EventArgs e)
        {
            this.IsAddressValid();
        }
        private void tbx_postal_code_TextChanged(object sender, EventArgs e)
        {
            this.IsPostalCodeValid();
        }
        private void tbx_ic_TextChanged(object sender, EventArgs e)
        {
            this.IsICValid();
        }
        #endregion

        #region Properties
        public CustomerModel CustomerModel { get; protected set; }
        #endregion
        #region Methods
        public bool IsValid()
        {
            bool isValid = true;

            isValid &= this.IsNameValid();
            isValid &= this.IsAddressValid();
            isValid &= this.IsPostalCodeValid();
            isValid &= this.IsICValid();

            return isValid;
        }
        #endregion

        #region Validation
        protected bool IsNameValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_name.Text))
            {
                this.errorProvider1.SetError(this.tbx_name, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_name, null);
            }

            return isValid;
        }
        protected bool IsAddressValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_address_text.Text))
            {
                this.errorProvider1.SetError(this.tbx_address_text, "Pole nesmí být prázdné");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_address_text, null);
            }

            return isValid;
        }
        protected bool IsPostalCodeValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_postal_code.Text))
            {
                this.errorProvider1.SetError(this.tbx_postal_code, "Pole nesmí být prázdné");
                isValid = false;
            }
            else if (!Regex.IsMatch(this.tbx_postal_code.Text, "^([0-9]{3} ?[0-9]{2})$"))
            {
                this.errorProvider1.SetError(this.tbx_postal_code, "Zadaná hodnota není PSČ");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_postal_code, null);
            }

            return isValid;
        }
        protected bool IsICValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(this.tbx_ic.Text))
            {
                this.errorProvider1.SetError(this.tbx_ic, "Pole nesmí být prázdné");
                isValid = false;
            }
            else if (!Regex.IsMatch(this.tbx_ic.Text, "^([0-9]{6})$"))
            {
                this.errorProvider1.SetError(this.tbx_ic, "Zadaná hodnota není IČ");
                isValid = false;
            }
            else
            {
                this.errorProvider1.SetError(this.tbx_ic, null);
            }

            return isValid;
        }
        #endregion
    }
}
