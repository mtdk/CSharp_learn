using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sources = new int[] { 20, 46, 24, 71, 120, 53, 12, 92, 38, 126 };
            //break直接跳出循环体
            foreach (int n in sources)
            {
                if (n==53)
                {
                    Console.WriteLine("元素已找到，马上跳出循环体。");
                    break;
                }
                else
                {
                    Console.WriteLine("暂未找到元素......");
                }
            }
            //continue跳出执行语句，进入下一次循环
            foreach (int n in sources)
            {
                if ((n%2)!=0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("{0}", n);
                }
            }
            Console.Read();
        }
    }
}
