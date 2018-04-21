using ServiceProtocol.Interfaces;
using ServiceProtocol.Models.Dom;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ServiceProtocol.Models
{
    public class ServiceProtocolModel : IHtmlElement, IDrawable
    {
        public string ProtocolNumber { get; set; }
        public DateTime MeasurementDate { get; set; } = DateTime.Now;
        public CustomerModel Customer { get; set; } = new CustomerModel();
        public DeviceModel Device { get; set; } = new DeviceModel();
        public BindingList<MeasurementModel> Measurements { get; set; } = new BindingList<MeasurementModel>();

        public bool IsValid => this.Measurements.All(x => x.IsValid == "Ano");

        #region IHtmlSaveable
        public string ConvertToHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<div id=\"protokol\">");
            {
                sb.AppendLine("<h1>Potvrzení o provedení měření</h1>");
                sb.AppendLine($"<div id=\"datum\">Datum měření: { this.MeasurementDate.ToShortDateString()}</div>");
                sb.AppendLine($"<div id=\"cisloProtokolu\">Číslo protokolu: {this.ProtocolNumber}</div>");
                sb.AppendLine(this.Customer.ConvertToHtml());
                sb.AppendLine(this.Device.ConvertToHtml());

                sb.AppendLine("<div id=\"mereni\">");
                {
                    sb.AppendLine("<h2>Měření</h2>");
                    sb.AppendLine("<table>");
                    {
                        sb.AppendLine("<tr>");
                        {
                            sb.AppendLine("<th>Parametr</th>");
                            sb.AppendLine("<th>Naměřená hodnota</th>");
                            sb.AppendLine("<th>Vyhovuje</th>");
                        }
                        sb.AppendLine("</tr>");
                        foreach (MeasurementModel item in this.Measurements)
                        {
                            sb.AppendLine(item.ConvertToHtml());
                        }
                    }
                    sb.AppendLine("</table>");
                }
                sb.AppendLine("</div>");

                string conclusion = (this.IsValid) ? "Zařízení je schopné dalšího provozu" : "Zařízení není schopné dalšího provozu";

                sb.AppendLine($"<div id=\"zaver\">{conclusion}</div>");
            }
            sb.AppendLine("</div>");
            return sb.ToString();
        }
        public string GetCssStyle()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("h1 { text-align:center; }");
            sb.AppendLine("div#protokol { margin:2em; border:1px solid black; }");
            sb.AppendLine("div#datum { float:left; margin:1em; width:40%;  }");
            sb.AppendLine("div#cisloProtokolu { text-align:right; float:right; margin:1em; width:40%; }");
            sb.AppendLine("div#zaver { text-align:center; font-weight:bold; font-size:1.2em; }");
            sb.AppendLine(this.Customer.GetCssStyle());
            sb.AppendLine(this.Device.GetCssStyle());
            sb.AppendLine("div#mereni { clear:both; padding:1em; }");
            sb.AppendLine("div#mereni table { width:100%; }");
            sb.AppendLine("div#mereni table th { text-align:left; }");
            return sb.ToString();
        }
        #endregion

        #region IDrawable
        public void Draw(Graphics graphics)
        {
            string title = "Potvrzení o provedení měření";
            string conclusion = (this.IsValid ? "Zařízení je schopné dalšího provozu" : "Zařízení není schopné dalšího provozu");
            string protocolNo = $"Číslo protokolu: {this.ProtocolNumber}";
            string measuredValue = "Naměřená hodnota";
            string isAcceptable = "Vyhovuje";

            Font h1Bold = new Font("Arial", 14F, FontStyle.Bold);
            Font h2 = new Font("Arial", 12F);
            Font text = new Font("Arial", 10F);

            SizeF titleSize = graphics.MeasureString(title, h1Bold);
            SizeF conclusionSize = graphics.MeasureString(conclusion, h1Bold);
            SizeF protocolNoSize = graphics.MeasureString(protocolNo, text);
            SizeF measuredValueSize = graphics.MeasureString(measuredValue, h2);
            SizeF isAcceptableSize = graphics.MeasureString(isAcceptable, h2);

            graphics.DrawRectangle(Pens.Black, new Rectangle(10, 10, Convert.ToInt32(graphics.ClipBounds.Width) - 20, Convert.ToInt32(graphics.ClipBounds.Height) - 20));
            graphics.DrawString(title, h1Bold, Brushes.Black, new PointF(graphics.ClipBounds.Width / 2F - titleSize.Width / 2F, 30F));

            graphics.DrawString($"Datum měření: {this.MeasurementDate.ToShortDateString()}", text, Brushes.Black, new PointF(20F, 70F));
            graphics.DrawString(protocolNo, text, Brushes.Black, new PointF(graphics.ClipBounds.Width - 20F - protocolNoSize.Width, 70F));

            #region Customer information
            graphics.DrawRectangle(Pens.Black, new Rectangle(20, 100, Convert.ToInt32(graphics.ClipBounds.Width) / 2 - 35, 130));

            PointF cstPointF = new PointF(30F, 110F);
            graphics.DrawString("Zákazník", h2, Brushes.Black, cstPointF);
            graphics.DrawString($"Název: {this.Customer.Name}", text, Brushes.Black, new PointF(cstPointF.X, cstPointF.Y + 30F));
            graphics.DrawString($"Adresa: {this.Customer.Address}", text, Brushes.Black, new PointF(cstPointF.X, cstPointF.Y + 50F));
            graphics.DrawString($"PSČ: {this.Customer.PostalCode}", text, Brushes.Black, new PointF(cstPointF.X, cstPointF.Y + 70F));
            graphics.DrawString($"IČ: {this.Customer.IC}", text, Brushes.Black, new PointF(cstPointF.X, cstPointF.Y + 90F));
            #endregion

            #region Device information
            graphics.DrawRectangle(Pens.Black, new Rectangle(Convert.ToInt32(graphics.ClipBounds.Width) / 2 + 15, 100, Convert.ToInt32(graphics.ClipBounds.Width) / 2 - 35, 130));

            PointF devPointF = new PointF(graphics.ClipBounds.Width / 2F + 25F, 110F);
            graphics.DrawString("Zařízení", h2, Brushes.Black, devPointF);
            graphics.DrawString($"Výrobce: {this.Device.Manufacturer}", text, Brushes.Black, new PointF(devPointF.X, devPointF.Y + 30F));
            graphics.DrawString($"Model: {this.Device.Model}", text, Brushes.Black, new PointF(devPointF.X, devPointF.Y + 50F));
            graphics.DrawString($"Sériové číslo: {this.Device.SerialNumber}", text, Brushes.Black, new PointF(devPointF.X, devPointF.Y + 70F));
            #endregion

            PointF meaPointF = new PointF(30F, 260F); //250F
            graphics.DrawString("Měření", h2, Brushes.Black, meaPointF);
            graphics.DrawString("Parametr", h2, Brushes.Black, new PointF(20F, meaPointF.Y + 30F));
            graphics.DrawString(measuredValue, h2, Brushes.Black, new PointF(graphics.ClipBounds.Width / 2F - measuredValueSize.Width / 2F, meaPointF.Y + 30F));
            graphics.DrawString(isAcceptable, h2, Brushes.Black, new PointF(graphics.ClipBounds.Width - 20F - isAcceptableSize.Width, meaPointF.Y + 30F));

            for (int i = 0; i < this.Measurements.Count; i++)
            {
                MeasurementModel item = this.Measurements[i];
                SizeF meaValueSize = graphics.MeasureString(item.MeasuredValue.ToString() + item.Unit, text);
                SizeF meaIsAccSize = graphics.MeasureString(item.IsValid, text);

                graphics.DrawString(item.Parameter, text, Brushes.Black, new PointF(20F, meaPointF.Y + Convert.ToSingle(i) * 20F + 55F));
                graphics.DrawString(item.MeasuredValue.ToString() + item.Unit, text, Brushes.Black, new PointF(graphics.ClipBounds.Width / 2F - meaValueSize.Width / 2F, meaPointF.Y + Convert.ToSingle(i) * 20F + 55F));
                graphics.DrawString(item.IsValid, text, Brushes.Black, new PointF(graphics.ClipBounds.Width - 30F - meaIsAccSize.Width, meaPointF.Y + Convert.ToSingle(i) * 20F + 55F));
            }

            PointF cPointF = new PointF(graphics.ClipBounds.Width / 2F - conclusionSize.Width / 2F, meaPointF.Y + Convert.ToSingle(this.Measurements.Count) * 20F + 70F);
            graphics.DrawString(conclusion, h1Bold, Brushes.Black, cPointF);
        }
        #endregion
    }
}
