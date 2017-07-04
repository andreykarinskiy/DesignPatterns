namespace Visitor.Html
{
    public sealed class PlainText : HtmlElement
    {
        public override void Accept(IHtmlVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}