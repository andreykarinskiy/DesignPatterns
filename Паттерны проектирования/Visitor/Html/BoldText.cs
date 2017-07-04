namespace Visitor.Html
{
    public sealed class BoldText : HtmlElement
    {
        public override void Accept(IHtmlVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}