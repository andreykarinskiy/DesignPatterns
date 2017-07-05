namespace Interpreter
{
    public sealed class MulExpression : BinaryExpression
    {
        public MulExpression(Expression left, Expression right) : base(left, right)
        {
        }

        public override int Evaluate()
        {
            return left.Evaluate() * right.Evaluate();
        }
    }
}