using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10, b = 11;

            SwapInt(ref a, ref b);

            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
