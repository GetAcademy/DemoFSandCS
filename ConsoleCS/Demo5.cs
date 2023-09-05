using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCS
{
    internal class Demo5
    {
        public static void Run()
        {
            Func<Func<int, int>, int, int> applyTwice = (f, x) => f(f(x));
            Func<int, int> doubleIt = x => x * 2;
            int result = applyTwice(doubleIt, 3);

        }
    }
}
