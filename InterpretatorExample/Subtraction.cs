namespace InterpretatorExample
{
    internal class Subtraction : MathOperation
    {
        public Subtraction(Expression leftExpr, Expression rightExpr)
            : base(leftExpr, rightExpr) { }

        public override int doMath(Expression context)
        {
            return leftExpression.interpret(context) - rightExpression.interpret(context);
        }
    }
}
