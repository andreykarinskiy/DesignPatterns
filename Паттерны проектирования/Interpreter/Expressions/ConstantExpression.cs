namespace Interpreter
{
    public sealed class ConstantExpression : Expression
    {
        private readonly int value;

        public ConstantExpression(int value)
        {
            this.value = value;
        }

        public override int Evaluate()
        {
            return value;
        }
    }
}