namespace InterpretatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Expression evaluator = new Evaluator(expression);
            int result = evaluator.interpret(evaluator);

            Console.WriteLine(result);
        }
    }
}
