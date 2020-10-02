using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            //第一种情况
            switch (a)
            {
                case 1:
                    Console.WriteLine("一");
                    break;
                case 2:
                    Console.WriteLine("二");
                    break;
                case 3:
                    Console.WriteLine("三");
                    break;
                default:
                    Console.WriteLine("未知");
                    break;
            }

            a = 2;
            //第二种情况
            switch (a)
            {
                case 1:
                    Console.WriteLine("一");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("二或三");
                    break;
                default:
                    Console.WriteLine("未知");
                    break;
            }
        }
    }
}
