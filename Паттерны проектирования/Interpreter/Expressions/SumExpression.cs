namespace Interpreter
{
    public sealed class SumExpression : BinaryExpression
    {
        public SumExpression(Expression left, Expression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            return left.Evaluate() + right.Evaluate();
        }
    }
}