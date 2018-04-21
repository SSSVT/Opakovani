using ServiceProtocol.Models.Dom;

namespace ServiceProtocol.Interfaces
{
    interface IHtmlElement
    {
        string ConvertToHtml();
        string GetCssStyle();
    }
}
