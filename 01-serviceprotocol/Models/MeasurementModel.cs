using ServiceProtocol.Interfaces;
using ServiceProtocol.Models.Dom;
using System;
using System.ComponentModel;
using System.Text;

namespace ServiceProtocol.Models
{
    public class MeasurementModel : IHtmlElement
    {
        #region Properties
        public string Parameter { get; set; }

        [DisplayName("Naměřená hodnota")]
        public double MeasuredValue { get; set; }

        [DisplayName("Jednotka")]
        public string Unit { get; set; }

        [DisplayName("Vyhovuje")]
        public string IsValid
        {
            get => (this._IsValid) ? "Ano" : "Ne";
            set => this._IsValid = (value == "Ano") ? true : false;
        }
        #endregion

        #region Fields
        protected bool _IsValid;
        #endregion

        public string GetCssStyle()
        {
            return "";
        }

        public string ConvertToHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<tr>");
            {
                sb.AppendLine($"<td>{this.Parameter}</td>");
                sb.AppendLine($"<td>{this.MeasuredValue}{this.Unit}</td>");
                sb.AppendLine($"<td>{this.IsValid}</td>");
            }
            sb.AppendLine("</tr>");
            return sb.ToString();
        }
    }
}
