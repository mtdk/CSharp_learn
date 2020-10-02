using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个整型数组
            int[] numbers = new int[] { 2, 50, 22, 9, 17, 85 };
            //循环输出数组中的每个元素
            foreach (int n in numbers)
            {
                Console.Write("{0}", n);
            }

            Console.Read();
        }
    }
}
