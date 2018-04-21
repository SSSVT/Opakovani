using ServiceProtocol.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ServiceProtocol
{
    public partial class MainGUI : Form
    {
        protected ServiceProtocolModel ServiceProtocolModel { get; set; } = new ServiceProtocolModel();

        public MainGUI()
        {
            InitializeComponent();
            this.dgv_measurements.DataSource = this.ServiceProtocolModel.Measurements;
        }

        #region General
        private void btn_general_edit_Click(object sender, EventArgs e)
        {
            GeneralGUI generalGUI = new GeneralGUI(this.ServiceProtocolModel);
            if (generalGUI.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
        }
        #endregion
        #region Customer
        private void btn_customer_edit_Click(object sender, EventArgs e)
        {
            CustomerGUI customerGUI = new CustomerGUI(this.ServiceProtocolModel.Customer);
            if (customerGUI.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
        }
        #endregion
        #region Device
        private void btn_device_edit_Click(object sender, EventArgs e)
        {
            DeviceGUI deviceGUI = new DeviceGUI(this.ServiceProtocolModel.Device);
            if (deviceGUI.ShowDialog() == DialogResult.OK)
            {
                this.Refresh();
            }
        }
        #endregion
        #region Measurement
        private void btn_measurement_add_Click(object sender, EventArgs e)
        {
            MeasurementGUI measurementGUI = new MeasurementGUI();
            if (measurementGUI.ShowDialog() == DialogResult.OK)
            {
                this.ServiceProtocolModel.Measurements.Add(measurementGUI.MeasurementModel);
            }
        }
        private void btn_measurement_edit_Click(object sender, EventArgs e)
        {
            if (this.dgv_measurements.CurrentRow != null)
            {
                MeasurementModel model = this.ServiceProtocolModel.Measurements.ElementAt(this.dgv_measurements.CurrentRow.Index);
                MeasurementGUI measurementGUI = new MeasurementGUI(model);
                measurementGUI.ShowDialog(); //Využívání referenčních datových typů není trestné
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Vyberte řádek pro úpravu", Application.ProductName);
            }                
        }
        private void btn_measurement_delete_Click(object sender, EventArgs e)
        {
            if (this.dgv_measurements.CurrentRow != null)
                this.ServiceProtocolModel.Measurements.RemoveAt(this.dgv_measurements.CurrentRow.Index);
        }
        #endregion

        public override void Refresh()
        {
            base.Refresh();

            ServiceProtocolModel model = this.ServiceProtocolModel;

            this.lbl_general_protocol_no.Text = model.ProtocolNumber ?? "?";
            this.lbl_general_measurement_date.Text = (model.MeasurementDate != null) ? model.MeasurementDate.ToShortDateString() : "?";

            this.lbl_customer_name.Text = model.Customer.Name ?? "?";
            this.lbl_customer_address.Text = model.Customer.Address ?? "?";
            this.lbl_customer_postal_code.Text = model.Customer.PostalCode ?? "?";
            this.lbl_customer_ic.Text = model.Customer.IC ?? "?";

            this.lbl_device_manufacturer.Text = model.Device.Manufacturer ?? "?";
            this.lbl_device_model.Text = model.Device.Model ?? "?";
            this.lbl_device_serial_number.Text = model.Device.SerialNumber ?? "?";

            this.dgv_measurements.DataSource = model.Measurements;
        }

        private void btn_form_preview_Click(object sender, EventArgs e)
        {
            PrintPreviewGUI printPreviewGUI = new PrintPreviewGUI(this.ServiceProtocolModel);
            printPreviewGUI.ShowDialog();
        }
        private void btn_form_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                Filter = "XML files (*.xml)|*.xml",
                DefaultExt = "xml",
                Title = "Uložit jako"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile()))
                {
                    XmlSerializer serializer = new XmlSerializer(this.ServiceProtocolModel.GetType());
                    serializer.Serialize(sw, this.ServiceProtocolModel);
                }
            }            
        }
        private void btn_form_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "XML files (*.xml)|*.xml",
                Title = "Open",
                DefaultExt = "xml"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.OpenFile()))
                {
                    XmlSerializer serializer = new XmlSerializer(this.ServiceProtocolModel.GetType());
                    ServiceProtocolModel model = serializer.Deserialize(sr) as ServiceProtocolModel;
                    this.ServiceProtocolModel = model;
                    this.Refresh();
                }
            }
        }

        private void btn_form_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                Filter = "HTML files (*.html)|*.html",
                Title = "Exportovat",
                DefaultExt = "html"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<!DOCTYPE html>");
                sb.AppendLine("<html>");
                {
                    sb.AppendLine("<head>");
                    {
                        sb.AppendLine("<meta http-equiv=\"content-type\" content=\"text/html; charset=utf-8\">");
                        sb.AppendLine("<style>");
                        {
                            sb.AppendLine(this.ServiceProtocolModel.GetCssStyle());
                        }
                        sb.AppendLine("</style>");
                    }
                    sb.AppendLine("</head>");
                    sb.AppendLine("<body>");
                    {
                        sb.AppendLine(this.ServiceProtocolModel.ConvertToHtml());
                    }
                    sb.AppendLine("</body>");
                }
                sb.AppendLine("</html>");

                using (StreamWriter sw = new StreamWriter(dialog.OpenFile()))
                {
                    sw.WriteLine(sb.ToString());
                }
            }
        }
    }
}
