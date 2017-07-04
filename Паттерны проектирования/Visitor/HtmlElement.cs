namespace Visitor
{
    public abstract class HtmlElement : IHtmlVisitable
    {
        public string Content { get; set; }

        public abstract void Accept(IHtmlVisitor visitor);
    }
}