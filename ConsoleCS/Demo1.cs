namespace ConsoleCS
{
    internal class Demo1
    {
        public static void Run()
        {
            // currying og partial application
            Func<int, int, int> addNotCurried = (a, b) => a + b;
            Func<int, Func<int, int>> addCurried = a => b => a + b;
            Func<int, int> add5 = addCurried(5);
            int result = add5(7);
        }

        //public static int Add(int a, int b)
        //{
        //    return a+ b;
        //}
    }
}
