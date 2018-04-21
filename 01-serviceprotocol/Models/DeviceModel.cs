using ServiceProtocol.Interfaces;
using System.Text;

namespace ServiceProtocol.Models
{
    public class DeviceModel : IHtmlElement
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }

        public string GetCssStyle()
        {
            return "div#zarizeni { border:1px solid black; margin:1em; padding:1em; width:40%; float:right; }";
        }

        public string ConvertToHtml()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<div id=\"zarizeni\">");
            {
                sb.AppendLine($"<h2>Zařízení</h2>");
                sb.AppendLine($"<div>Výrobce: {this.Manufacturer}</div>");
                sb.AppendLine($"<div>Model: {this.Model}</div>");
                sb.AppendLine($"<div>Sériové číslo: {this.SerialNumber}</div>");
            }
            sb.AppendLine("</div>");

            return sb.ToString();
        }
    }
}
