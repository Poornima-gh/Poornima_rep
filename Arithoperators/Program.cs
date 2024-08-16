using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithoperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 27;
            int b = 3;
            int c = 5;
            Console.WriteLine((a + b) +" "+ (a % c)); //+ as binary operator
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a % c);

            int i = +8; //+ as unary operator
            int j = -16;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(j / i);
            int k = -j;
            Console.WriteLine(k);
        }
    }
}
