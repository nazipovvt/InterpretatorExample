namespace InterpretatorExample
{
    internal class Addition : MathOperation
    {
        public Addition(Expression leftExpr, Expression rightExpr)
            : base(leftExpr, rightExpr) { }

        public override int doMath(Expression context)
        {
            return leftExpression.interpret(context) + rightExpression.interpret(context);
        }
    }
}
