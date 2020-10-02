using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个100以内（含100）的数字：");
            //读取用户输入的内容
            string readInput = Console.ReadLine();
            //将接收到的字符串转为双精度值
            double d = Convert.ToDouble(readInput);
            //进行判断处理
            if (d > 100)
            {
                Console.WriteLine("无效数字");
            }
            else if(d>70)
            {
                Console.WriteLine("C阶段");
            }
            else if(d>30)
            {
                Console.WriteLine("B阶段");
            }
            else
            {
                Console.WriteLine("A阶段");
            }

            Console.Read();
        }
    }
}
