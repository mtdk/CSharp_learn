using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            while (s.Length < 15)
            {
                s = s + "*";
                Console.WriteLine(s);
            }
            Console.WriteLine("\n\n");
            //---------------------------
            //至少循环一次
            int k = 3;
            do
            {
                Console.WriteLine("至少执行一次，输出：{0}", k);
            } while (k<2);

            Console.WriteLine("\n\n");
            //在0到20的整数中，输出偶数
            int n = 0;
            do
            {
                if ((n%2)==0)
                {
                    Console.WriteLine("{0}", n);
                }
                //n加1
                n++;
            } while (n<=20);

            Console.Read();
        }
    }
}
