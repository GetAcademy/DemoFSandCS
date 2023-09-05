namespace ConsoleCS
{
    internal class Demo3
    {
        public static void Run()
        {
            Func<int,int> add1 = x => x + 1;
            Func<int,int> doubleIt = x => x * 2;
            Func<int,int> square = x => x * x;

            Func<int, int> add1DoubleAndSquare = x => square(doubleIt(add1(x)));
            int result = add1DoubleAndSquare(5);

        }
    }
}
