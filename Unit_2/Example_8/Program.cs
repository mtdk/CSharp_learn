using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //按位与运算
            byte a1 = 36;
            byte b1 = 100;
            Console.WriteLine("{0} & {1} = {2}", Convert.ToString(a1, 2), Convert.ToString(b1, 2), Convert.ToString(a1 & b1, 2));
    
            //按位或运算
            byte a2 = 19;
            byte b2 = 218;
            Console.WriteLine("{0} | {1} = {2}", Convert.ToString(a2, 2), Convert.ToString(b2, 2), Convert.ToString(a2 | b2, 2));

            //左移位运算
            byte a3 = 167;
            Console.WriteLine("{0} << 5 = {1}", Convert.ToString(a3, 2), Convert.ToString(a3 << 5, 2));

            //右移运算
            byte a4 = 200;
            Console.WriteLine("{0} >> 5 = {1}", Convert.ToString(a4, 2), Convert.ToString(a4 >> 5, 2));

            Console.Read();
        }
    }
}
