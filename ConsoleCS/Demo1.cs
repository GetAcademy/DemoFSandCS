namespace ConsoleCS
{
    internal class Demo1
    {
        public static void Run()
        {
            // currying og partial application
            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int> add5 = b => add(5, b);
            int result = add5(7);
        }
    }
}
