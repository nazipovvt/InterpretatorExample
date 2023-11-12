using System.Text.RegularExpressions;

namespace InterpretatorExample
{
    internal class Evaluator : Expression
    {
        Expression _toEvaluate;

        public Evaluator(string unparcedExpression)
        {
            char[] toReverse = unparcedExpression.ToCharArray();
            Array.Reverse(toReverse);
            string numbersReversed = new string(toReverse);

            string opSplitter = @"\d+";
            string decimalSplitter = @"[+-]";

            Stack<Expression> parsedExpressions = new Stack<Expression>();

            foreach (string expression in Regex.Split(numbersReversed, decimalSplitter))
            {
                parsedExpressions.Push(new Number(int.Parse(expression)));
            }

            foreach (string expression in Regex.Split(unparcedExpression, opSplitter))
            {
                string[] splitArray = Regex.Split(unparcedExpression, opSplitter);
                switch (expression)
                {
                    case "+":
                        parsedExpressions.Push(new Addition(parsedExpressions.Pop(), parsedExpressions.Pop()));
                        break;
                    case "-":
                        parsedExpressions.Push(new Subtraction(parsedExpressions.Pop(), parsedExpressions.Pop()));
                        break;
                    default:
                        break;
                }
            }

            _toEvaluate = parsedExpressions.Pop();
        }

        public int interpret(Expression context)
        {
            return _toEvaluate.interpret(context);
        }
    }
}
