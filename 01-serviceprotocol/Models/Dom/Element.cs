using System.Collections.Generic;
using System.Text;

namespace ServiceProtocol.Models.Dom
{
    public class Element
    {
        public string TagName { get; set; }
        public string Id { get; set; }
        public List<Element> ChildNodes { get; set; }

        protected Element()
        {

        }
        public Element(string tagName, params Element[] childNodes) : this(tagName, null, childNodes)
        {

        }
        public Element(string tagName, string id, params Element[] childNodes)
        {
            this.TagName = tagName;
            this.Id = id;
            this.ChildNodes = new List<Element>(childNodes);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string id = (this.Id != null) ? $"id=\"{this.Id}\"" : "";
            sb.AppendLine($"<{this.TagName} {id}>");

            foreach (Element item in this.ChildNodes)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"</{this.TagName}>");

            return sb.ToString();
        }
    }

    public class TextElement : Element
    {
        public TextElement(string text) : base()
        {
            this.Text = text;
        }
        public string Text { get; set; }
        public override string ToString() => this.Text;
    }
}
