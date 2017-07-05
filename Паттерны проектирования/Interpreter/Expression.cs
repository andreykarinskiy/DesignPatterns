namespace Interpreter
{
    public abstract class Expression
    {
        public abstract int Evaluate();

        public static Expression operator +(Expression left, Expression right)
        {
            return new SumExpression(left, right);
        }

        public static Expression operator *(Expression left, Expression right)
        {
            return new MulExpression(left, right);
        }
    }
}