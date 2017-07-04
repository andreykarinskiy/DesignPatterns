using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Visitor.Html;
using Visitor.Visitors;

namespace Visitor
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var visitor = new RenderVisitor();

            var element = new BoldText { Content = "это html тег" };
            element.Accept(visitor);

            Console.ReadLine();
        }
    }
}
