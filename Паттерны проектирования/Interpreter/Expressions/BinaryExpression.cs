namespace Interpreter
{
    public abstract class BinaryExpression : Expression
    {
        protected readonly Expression left;
        protected readonly Expression right;

        protected BinaryExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}