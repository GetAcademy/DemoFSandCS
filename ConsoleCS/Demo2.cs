namespace ConsoleCS
{
    internal class Demo2
    {
        public static void Run()
        {
            
        }

        int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        // men
        int FactorialSwitch(int n)
        {
            return n switch
            {
                0 => 1,
                _ => n * Factorial(n - 1)
            };
        }
    }
}
