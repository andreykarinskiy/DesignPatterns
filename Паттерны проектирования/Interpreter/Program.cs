using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 30 + 20 * 10 = 230
            var root = new SumExpression(
                new MulExpression(
                    new ConstantExpression(10),
                    new ConstantExpression(20)),
                new ConstantExpression(30));

            var result = root.Evaluate();


            // 30 + 20 * 10 = 230
            var a = new ConstantExpression(30);
            var b = new ConstantExpression(20);
            var c = new ConstantExpression(10);

            var x = a + b * c;

            var value = x.Evaluate();
        }
    }
}
