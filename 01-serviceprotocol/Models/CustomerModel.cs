using ServiceProtocol.Interfaces;
using System.Text;

namespace ServiceProtocol.Models
{
    public class CustomerModel : IHtmlElement
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string IC { get; set; }

        public string ConvertToHtml()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<div id=\"zakaznik\">");
            {
                sb.AppendLine($"<h2>Zákazník</h2>");
                sb.AppendLine($"<div>Název: {this.Name}</div>");
                sb.AppendLine($"<div>Adresa: {this.Address}</div>");
                sb.AppendLine($"<div>PSČ: {this.PostalCode}</div>");
                sb.AppendLine($"<div>IČ: {this.IC}</div>");
            }
            sb.AppendLine("</div>");

            return sb.ToString();
        }

        public string GetCssStyle()
        {
            return "div#zakaznik { border:1px solid black; margin:1em; padding:1em; width:40%; float:left; }";
        }
    }
}
