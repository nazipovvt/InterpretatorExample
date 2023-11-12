namespace InterpretatorExample
{
    internal abstract class MathOperation : Expression
    {
        public Expression leftExpression;
        public Expression rightExpression;

        public MathOperation(Expression leftExpr, Expression rightExpr)
        {
            leftExpression = leftExpr;
            rightExpression = rightExpr;
        }

        public abstract int doMath(Expression context);

        public int interpret(Expression context)
        {
            return doMath(context);
        }
    }
}
