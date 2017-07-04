using Visitor.Html;

namespace Visitor
{
    public interface IHtmlVisitor
    {
        void Visit(PlainText element);

        void Visit(BoldText element);

        void Visit(StrikeoutText element);
    }
}