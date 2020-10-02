using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            double d;
            for (string x = Console.ReadLine(); double.TryParse(x, out d); x = Console.ReadLine())
            {
                Console.WriteLine("你输入的数字是：{0}", d);
            }

            Console.Read();
        }
    }
}
