using System;

using Visitor.Html;

namespace Visitor.Visitors
{
    public sealed class RenderVisitor : IHtmlVisitor
    {
        public void Visit(PlainText element)
        {
            Console.Write(element.Content);
        }

        public void Visit(BoldText element)
        {
            Console.Write($"<b>{element.Content}</b>");
        }

        public void Visit(StrikeoutText element)
        {
            Console.Write($"<strike>{element.Content}</strike>");
        }
    }
}