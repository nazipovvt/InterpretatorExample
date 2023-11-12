namespace InterpretatorExample
{
    internal class Number : Expression
    {
        int _number;

        public Number(int number)
        {
            _number = number;
        }

        public int interpret(Expression context)
        {
            return _number;
        }
    }
}
