namespace Visitor.Html
{
    public sealed class StrikeoutText : HtmlElement
    {
        public override void Accept(IHtmlVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}