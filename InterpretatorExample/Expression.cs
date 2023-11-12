namespace InterpretatorExample
{
    internal interface Expression
    {
        public int interpret(Expression context);
    }
}
